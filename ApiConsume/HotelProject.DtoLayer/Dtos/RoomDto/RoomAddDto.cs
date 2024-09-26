using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public String RoomNumber { get; set; }
        public String RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz.")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]
        public String BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public String BathCount { get; set; }
        public String Wifi { get; set; }
        public String Description { get; set; }
    }
}
