using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public partial class UserRegistrationModel
    {
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}