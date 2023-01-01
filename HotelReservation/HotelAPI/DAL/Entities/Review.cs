using System;
namespace HotelAPI.DAL.Entities
{
	public class Review
	{
		public Review()
		{
		}

        public int ID { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerEmail { get; set; }
        public string Description { get; set; }
        public string ReviewerPhoto { get; set; }
        public DateTime Date { get; set; }
        public string Rating { get; set; }
    }
}

