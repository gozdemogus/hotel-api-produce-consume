using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseIdentity.PresentationLayer.Controllers
{
    public class BookingController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FindRoom(RoomType roomType)
        {
         
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/api/Room/roomByTypeName/{roomType.Name}");

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Room>>(jsonData);
              
                return View(result);
            }
            else
            {
                return View();
            }

        }

     
        public async Task<IActionResult> NewBookingAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/api/RoomType");
            var result = new List<RoomType>();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
               result = JsonConvert.DeserializeObject<List<RoomType>>(jsonData);

            }


            List<SelectListItem> roomTypes = (from x in result
                                                     select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.Name.ToString()
                                                     }).ToList();
            roomTypes.Insert(0, new SelectListItem { Text = "Select", Value = string.Empty });

            ViewBag.type = roomTypes;

            return View();
        }

        [HttpPost]
        public async void MakeBooking(BookingViewModel booking)
        {
            Booking booking1 = new Booking();
            Room room = new Room();
            RoomType roomType = new RoomType();
            roomType.Name = booking.RoomType;

            room.RoomType = roomType;
            booking1.Room = room;
            booking1.CheckIn = booking.CheckIn;
            booking1.CheckOut = booking.CheckOut;
            booking1.GuestsCount = booking.GuestsCount;


            var client = _httpClientFactory.CreateClient();
            var reviewJson = JsonConvert.SerializeObject(booking1);

            // Wrap the JSON string in an HttpContent object.
            var content = new StringContent(reviewJson, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:5001/api/Booking", content);

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Room>>(jsonData);

            }
            return;
        }


    }
}

