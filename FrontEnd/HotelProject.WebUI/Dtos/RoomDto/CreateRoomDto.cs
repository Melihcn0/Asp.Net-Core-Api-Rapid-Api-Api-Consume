using System;

namespace HotelProject.WebUI.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        public String RoomNumber { get; set; }
        public String RoomCoverImage { get; set; }
        public int Price { get; set; }
        public String Title { get; set; }
        public String BedCount { get; set; }
        public String BathCount { get; set; }
        public String Wifi { get; set; }
        public String Description { get; set; }
    }
}

