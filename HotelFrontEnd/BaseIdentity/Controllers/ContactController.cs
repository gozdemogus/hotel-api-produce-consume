using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseIdentity.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async void AddAsync(Contact contact)
        {
            var client = _httpClientFactory.CreateClient();
            var reviewJson = JsonConvert.SerializeObject(contact);

            // Wrap the JSON string in an HttpContent object.
            var content = new StringContent(reviewJson, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:5001/api/Contact/", content);

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Room>>(jsonData);


            }
            return;
         
        }

    }
}

