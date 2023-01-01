using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.DAL.Entities;
using HotelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using UpSchool_WebApi.DAL;
using UpSchool_WebApi.DAL.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = context.Bookings.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult MakeABooking(BookingAddViewModel booking)
        {
            Booking booking1 = new Booking();
            Room room = new Room();
            room.Available = false;
            Guest guest = new Guest();

            booking1.Room = room;
            booking1.Room.RoomType = context.RoomTypes.FirstOrDefault(rt => rt.Name == booking.Room.RoomType.Name);

            booking1.Guest = guest;
            booking1.GuestsCount = booking.GuestsCount;
            booking1.CheckOut = booking.CheckOut;
            booking1.Room.RoomType.Name = booking.Room.RoomType.Name;
            booking1.DateCreated = DateTime.Now;
            var values = context.Bookings.Add(booking1);
            context.SaveChanges();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var values = context.Bookings.Find(id);
            return Ok(values);
        }

        [HttpGet("{checkIn, checkOut}")]
        public IActionResult GetBookingByDate(DateTime checkIn, DateTime checkOut)
        {
            var values = context.Bookings
                .Where(x => x.CheckIn >= checkIn && x.CheckOut <= checkOut);
            return Ok(values);
        }


        [HttpDelete("{id}")]
        public IActionResult CancelBooking(int id)
        {
            var values = context.Bookings.Find(id);
            context.Bookings.Remove(values);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            var values = context.Bookings.Find(booking.ID);
            values.Room = booking.Room;
            values.Guest = booking.Guest;
            values.Room = booking.Room;
            values.CheckIn = booking.CheckOut;
            values.CheckOut = booking.CheckOut;
            context.SaveChanges();
            return Ok();
        }
    }
}

