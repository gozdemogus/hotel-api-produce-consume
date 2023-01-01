using System;
using System.Collections.Generic;
using System.Net.Http;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BaseIdentity.PresentationLayer.Controllers
{
    public class RoomTypeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomTypeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/api/RoomType");

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<RoomType>>(jsonData);

                return View(result);
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> FindRoom(string id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/api/Room/roomByTypeName/{id}");

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

    }
}

