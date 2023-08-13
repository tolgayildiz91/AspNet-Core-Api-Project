using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string Password { get; set; }
    }
}
