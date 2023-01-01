using System;
namespace HotelAPI.DAL.Entities
{
	public class Contact
	{
		public Contact()
		{
		}

		public int Id { get; set; }
		public string SenderName { get; set; }
		public string SenderEmail { get; set; }
		public string Message { get; set; }
		public DateTime dateTime { get; set; }
	}
}

