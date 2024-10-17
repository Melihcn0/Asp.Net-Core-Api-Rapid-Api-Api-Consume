﻿using HotelProject.EntityLayer.Concrete;
using System;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String City { get; set; }
        public String ImageUrl { get; set; }
        public String WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
    }
}
