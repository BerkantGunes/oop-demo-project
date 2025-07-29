using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        // Attributes and Props
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter username")]
        public string UserName { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter password")]
        [Compare("Password", ErrorMessage ="Password and Confirm Password must the same")]
        public string ConfirmPassword { get; set; }
    }
}
