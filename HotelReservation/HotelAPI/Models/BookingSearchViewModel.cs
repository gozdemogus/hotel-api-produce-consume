using System;
using HotelAPI.DAL.Entities;

namespace HotelAPI.Models
{
	public class BookingSearchViewModel
	{
		public BookingSearchViewModel()
		{
		}
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int GuestsCount { get; set; }
        public string RoomType { get; set; }
    }
}

