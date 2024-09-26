using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class NewUserAddDto
    {
        [Required(ErrorMessage ="Ad alanı Gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı Gereklidir.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı Gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail alanı Gereklidir.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı Gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı Gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

    }
}
