using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkTest.MVC.Entities
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The Email Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "The Password Is Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe {  get; set; }
    }
}
