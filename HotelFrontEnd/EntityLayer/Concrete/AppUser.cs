using System;
using Microsoft.AspNetCore.Identity;

namespace BaseIdentity.EntityLayer.Concrete
{
	public class AppUser:IdentityUser<int>
	{
		public AppUser()
		{
		}

		public string  Gender { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Image { get; set; }
	}
}

