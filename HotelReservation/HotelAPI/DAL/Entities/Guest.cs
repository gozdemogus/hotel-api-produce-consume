using System;
using System.Collections.Generic;

namespace HotelAPI.DAL.Entities
{
	public class Guest
	{
		public Guest()
		{
		}
		public int GuestId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}

