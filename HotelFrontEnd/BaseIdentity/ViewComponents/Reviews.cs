using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BaseIdentity.PresentationLayer.ViewComponents
{
	public class Reviews:ViewComponent
	{


        private readonly IHttpClientFactory _httpClientFactory;

        public Reviews(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5001/reviewbyroom/{id}");

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Review>>(jsonData);

                return View(result);
            }
            else
            {
                return View();
            }
          
        }
    }
}

