using System;
using System.Collections.Generic;
using System.Net.Http;
using BaseIdentity.PresentationLayer.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Buffers.Text;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace BaseIdentity.PresentationLayer.ViewComponents
{
    public class Weather : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Weather(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

     
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            string apiKey = _configuration["MyApiKey"];

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul"),
                Headers =
    {
        { "X-RapidAPI-Key", apiKey },
        { "X-RapidAPI-Host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(body);

                    // Get the value of the feels_like property
                    double feelsLike = data.main.feels_like;
                  
                        ViewBag.feelsLike = feelsLike;
                  
                }

                return View();
            }
          
            }
        }

    }

