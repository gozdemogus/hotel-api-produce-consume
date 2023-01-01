using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace HotelAPI.DAL.Entities
{
	public class Room
	{
		public Room()
		{
		}

		public int Id { get; set; }
        public int Number { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        public string BedSize { get; set; }
    
    }
}

