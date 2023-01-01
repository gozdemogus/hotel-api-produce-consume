using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UpSchool_WebApi.DAL;
using UpSchool_WebApi.DAL.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult RoomTypeList()
        {
            var values = context.RoomTypes.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult RoomTypeAdd(RoomType roomType)
        {
            context.RoomTypes.Add(roomType);
            context.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetRoomTypeById(int id)
        {
            var values = context.RoomTypes.Find(id);
            return Ok(values);
        }



        [HttpGet("type/{name}")]
        public IActionResult GetRoomTypeByName(string name)
        {
            var values = context.RoomTypes.Where(x=>x.Name == name);
            return Ok(values);
        }
    }
}

