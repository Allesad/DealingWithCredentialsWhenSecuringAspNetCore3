using System.ComponentModel.DataAnnotations;

namespace Marvin.IDP.Account
{
    public class AdditionalAuthenticationFactorViewModel
    {
        public string ReturnUrl { get; set; }
        public bool RememberLogin { get; set; }
        [Required]
        public string Totp { get; set; }
    }
}
