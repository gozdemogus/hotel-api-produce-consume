using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.DAL.Entities;
using HotelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UpSchool_WebApi.DAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = context.Rooms.Where(x=>x.Available==true).Include(x=>x.Reviews).Include(x=>x.RoomType).Include(x=>x.Bookings).ToList();
            return Ok(values);
        }

        [HttpGet("{number}")]
        public IActionResult GetRoomByNumber(int number)
        {
            var values = context.Rooms.Where(x => x.Number == number && x.Available==true).First();
            RoomType rt = (RoomType)context.RoomTypes.Where(x => x.Id == values.RoomTypeId).FirstOrDefault();

            values.RoomType = rt;

            return Ok(values);
        }


        [HttpGet("roomByTypeName/{typeName}")]
        public IActionResult GetRoomByType(string typeName)
        {
            var values = context.Rooms.Include(x => x.RoomType).Where(x => x.RoomType.Name == typeName && x.Available == true);
            return Ok(values);
        }
    }
}

