using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "şifreyi giriniz")]
        public string password { get; set; }
    }
}
