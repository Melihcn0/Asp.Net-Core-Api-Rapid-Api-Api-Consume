using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:40699/api/MessageCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsondata);
                List<SelectListItem> values2 = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.MessageCategoryName,
                                                    Value = x.MessageCategoryID.ToString()
                                                }).ToList();
                ViewBag.MessageCategoryID = values2;
            }
            else
            {

            }

            return View();


        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            if (ModelState.IsValid)
            {
                createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createContactDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:40699/api/Contact", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Default");
                }
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}

