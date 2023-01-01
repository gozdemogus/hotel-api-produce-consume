using HotelAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using UpSchool_WebApi.DAL.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace UpSchool_WebApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=HotelAPI;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
