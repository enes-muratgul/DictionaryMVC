using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Mail Gerekli!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Sifre Gerekli!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
