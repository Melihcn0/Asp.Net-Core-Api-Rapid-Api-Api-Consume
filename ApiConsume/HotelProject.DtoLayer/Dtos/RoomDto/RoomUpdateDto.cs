using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public String RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]
        public String RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz.")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]
        public String BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public String BathCount { get; set; }
        public String Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]
        public String Description { get; set; }
    }
}
