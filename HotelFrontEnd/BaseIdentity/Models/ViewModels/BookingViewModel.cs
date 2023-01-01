﻿using System;
namespace BaseIdentity.PresentationLayer.Models
{
	public class BookingViewModel
	{
		public BookingViewModel()
		{
		}

        public int ID { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string GuestsCount { get; set; }
        public decimal TotalFee { get; set; }
        public bool Paid { get; set; }
        public bool Completed { get; set; }
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; }
        //public string CustomerName { get; set; }
        //public string CustomerEmail { get; set; }
        //public string CustomerPhone { get; set; }
        //public string CustomerAddress { get; set; }
        //public string CustomerCity { get; set; }
        public string OtherRequests { get; set; }
        public string RoomType { get; set; }

    }
}

