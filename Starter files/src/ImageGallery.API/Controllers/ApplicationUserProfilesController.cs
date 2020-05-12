using AutoMapper;
using ImageGallery.API.Services;
using ImageGallery.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ImageGallery.API.Controllers
{
    [Route("api/applicationuserprofiles")]
    [ApiController]
    [Authorize]
    public class ApplicationUserProfilesController : ControllerBase
    {
        private readonly IGalleryRepository _galleryRepository;

        private readonly IMapper _mapper;

        public ApplicationUserProfilesController(IGalleryRepository galleryRepository, IMapper mapper)
        {
            _galleryRepository = galleryRepository ?? throw new ArgumentNullException(nameof(galleryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize(Policy = "SubjectMustMatchUser")]
        [HttpGet("{subject}", Name = "GetApplicationUserProfile")]
        public IActionResult GetApplicationUserProfile(string subject)
        {
            var profileFromRepo = _galleryRepository.GetUserProfile(subject);

            if (profileFromRepo == null)
            {
                // subject must come from token
                var subjectFromToken = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

                profileFromRepo = new Entities.ApplicationUserProfile
                {
                    Subject = subjectFromToken,
                    SubscriptionLevel = "FreeUser"
                };

                _galleryRepository.AddUserProfile(profileFromRepo);
                _galleryRepository.Save();
            }

            return Ok(_mapper.Map<ApplicationUserProfile>(profileFromRepo));
        }

        [HttpPost]
        public IActionResult CreateApplicationUserProfile([FromBody] ApplicationUserProfileForCreation profile)
        {
            // currently the ApplicationUserProfileForCreation object doesn't have any properties,
            // as only the subscriptionlevel can be set and that's set to FreeUser for all
            // new users.  ApplicationUserProfileForCreation is accepted as an example
            // for when you would create a client-level screen where the user must input
            // field values before the profile can be created.  
            
            var subject = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

            if (_galleryRepository.UserProfileExists(subject)) return BadRequest();

            var profileEntity = _mapper.Map<Entities.ApplicationUserProfile>(profile);

            profileEntity.Subject = subject;
            profileEntity.SubscriptionLevel = "FreeUser";

            _galleryRepository.AddUserProfile(profileEntity);
            _galleryRepository.Save();

            var profileToReturn = _mapper.Map<ApplicationUserProfile>(profileEntity);

            return CreatedAtRoute("GetApplicationUserProfile", new { id = profileToReturn.Id }, profileToReturn);
        }
    }
}
