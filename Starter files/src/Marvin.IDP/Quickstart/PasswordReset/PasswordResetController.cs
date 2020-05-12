using Marvin.IDP.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Marvin.IDP.PasswordReset
{
    public class PasswordResetController : Controller
    {
        private readonly ILocalUserService _localUserService;

        public PasswordResetController(ILocalUserService localUserService)
        {
            _localUserService = localUserService ?? throw new ArgumentNullException(nameof(localUserService));
        }

        [HttpGet]
        public IActionResult RequestPassword()
        {
            return View(new RequestPasswordViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestPassword(RequestPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var securityCode = await _localUserService.InitiatePasswordResetRequest(model.Email);
            await _localUserService.SaveChangesAsync();

            var link = Url.Action("ResetPassword", "PasswordReset", new { securityCode });
            Debug.WriteLine(link);

            return View("PasswordResetRequestSent");
        }
    }
}