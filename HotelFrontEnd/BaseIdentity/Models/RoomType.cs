using System;
using System.ComponentModel.DataAnnotations;

namespace BaseIdentity.PresentationLayer.Models
{
    public class RoomType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Rating { get; set; }
        public int Capacity { get; set; }
        public string BedSize { get; set; }
        public string Size { get; set; }
        public string Services { get; set; }

    }

}