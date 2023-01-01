using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseIdentity.PresentationLayer.Controllers
{
    public class RoomController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public RoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        // GET: /<controller>/
        public async Task<IActionResult> Detail(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/api/Room/{id}");

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Room>(jsonData);

                return View(result);
            }
            else
            {
                return View();
            }
        }
    }
}

