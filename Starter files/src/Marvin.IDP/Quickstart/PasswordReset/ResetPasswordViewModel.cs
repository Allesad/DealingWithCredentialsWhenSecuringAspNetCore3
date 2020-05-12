using System.ComponentModel.DataAnnotations;

namespace Marvin.IDP.PasswordReset
{
    public class ResetPasswordViewModel
    {
        [Required]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        [Display(Name = "Your new password")]
        public string Password { get; set; }

        [Required]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        [Display(Name = "Config your new password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string SecurityCode { get; set; }
    }
}
