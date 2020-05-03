using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Marvin.IDP.Services
{
    public class LocalProfileService : IProfileService
    {
        private readonly ILocalUserService _localUserService;

        public LocalProfileService(ILocalUserService localUserService)
        {
            _localUserService = localUserService;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var subjectId = context.Subject.GetSubjectId();

            var claimsForUser = (await _localUserService.GetUserClaimsBySubjectAsync(subjectId)).ToList();

            context.AddRequestedClaims(claimsForUser.Select(c => new Claim(c.Type, c.Value))
                .ToList());
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var subjectId = context.Subject.GetSubjectId();
            context.IsActive = await _localUserService.IsUserActive(subjectId);
        }
    }
}
