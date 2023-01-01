using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using UpSchool_WebApi.DAL;
using UpSchool_WebApi.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult GuestList()
        {
            var values = context.Guests.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult NewGuest(Guest guest)
        {
            context.Guests.Add(guest);
            context.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = context.Guests.Find(id);
            return Ok(values);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = context.Guests.Find(id);
            context.Guests.Remove(values);
            context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Guest guest)
        {
            var values = context.Guests.Find(guest.GuestId);
            values.Address = guest.Address;
            values.Bookings = guest.Bookings;
            values.City = guest.City;
            
            context.SaveChanges();
            return Ok();
        }
    }
}

