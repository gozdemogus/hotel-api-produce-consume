using System;
using BaseIdentity.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace BaseIdentity.PresentationLayer.ViewComponents
{
	public class Booking:ViewComponent
    {
		public Booking()
		{
		}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

