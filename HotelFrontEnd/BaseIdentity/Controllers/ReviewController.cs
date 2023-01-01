using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BaseIdentity.PresentationLayer.Controllers
{
	public class ReviewController:Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public ReviewController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int x)
        {
            return View();
        }

        [HttpPost]
        public async void AddReview(Review review)
        {
            var client = _httpClientFactory.CreateClient();
            var reviewJson = JsonConvert.SerializeObject(review);

            // Wrap the JSON string in an HttpContent object.
            var content = new StringContent(reviewJson, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:5001/api/Review/",content);
         
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Room>>(jsonData);

             
            }
            return;
        }

    }
}

