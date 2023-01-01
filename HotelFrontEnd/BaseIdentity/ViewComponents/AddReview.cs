using System;
using BaseIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BaseIdentity.PresentationLayer.ViewComponents
{
    public class AddReview : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AddReview(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

    
        public IViewComponentResult Invoke(int id)
        {
            Review review = new Review();
            ViewBag.RoomID = id;
            return View(review);
        }
    }
}

