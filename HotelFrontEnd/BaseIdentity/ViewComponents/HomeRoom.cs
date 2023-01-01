using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BaseIdentity.PresentationLayer.ViewComponents
{
	public class HomeRoom : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public HomeRoom(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

		public async Task<IViewComponentResult> InvokeAsync()
		{

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:5001/api/RoomType");
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<RoomType>>(jsonData);
                List<RoomType> first4Room = result.Take(4).ToList();
                return View(first4Room);
            }
            else
            {
                return View();
            }
        }
	}

}