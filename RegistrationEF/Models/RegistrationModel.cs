using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationEF.Models
{
    public class RegistrationModel
    {

        [Key]
        public int RegistrationId { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a confim password.")]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter a email address.")]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number upto 10 Digits.")]
        //[MaxLength(10)]
        [StringLength(10, ErrorMessage = "Please enter valid phone number", MinimumLength = 10)]
        [DisplayName("Phone Number")]

        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        
        //public List<string> Hobbies { get; set; }
        ////public string UploadFile { get; set; }
        //[NotMapped]
        //public IFormFile UploadFile { get; set; }
    }
}
