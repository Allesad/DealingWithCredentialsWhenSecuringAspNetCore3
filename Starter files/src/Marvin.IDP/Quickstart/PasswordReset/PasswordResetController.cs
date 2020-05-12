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

            var link = Url.ActionLink("ResetPassword", "PasswordReset", new { securityCode });
            Debug.WriteLine(link);

            return View("PasswordResetRequestSent");
        }

        [HttpGet]
        public IActionResult ResetPassword(string securityCode)
        {
            var vm = new ResetPasswordViewModel
            {
                SecurityCode = securityCode
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await _localUserService.SetPassword(model.SecurityCode, model.Password))
            {
                ViewData["Message"] = "Your password was successfully changed. " +
                    "Navigate to your client application to log in.";
            }
            else
            {
                ViewData["Message"] = "Your password couldn't be changed, please " +
                    "contact your administrator";
            }

            await _localUserService.SaveChangesAsync();

            return View("ResetPasswordResult");
        }
    }
}