﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult testimonialList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Deletetestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult Updatetestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Gettestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);
        }
    }
}
