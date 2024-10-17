using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserservice;

        public AppUserController(IAppUserService appUserservice)
        {
            _appUserservice = appUserservice;
        }

        //[HttpGet]
        //public IActionResult UserListWithWorkLocation()
        //{
        //    var values = _appUserservice.TUserListWithWorkLocation();
        //    return Ok(values);
        //}
        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserservice.TGetList();
            return Ok(values);
        }
    }
}
