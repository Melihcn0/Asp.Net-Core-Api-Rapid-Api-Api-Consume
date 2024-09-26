using System.ComponentModel.DataAnnotations;
using System;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ServiceUpdateDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Servis ikon linki giriniz.")]
        public String ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir.")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması giriniz.")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir.")]
        public String Description { get; set; }
    }
}
