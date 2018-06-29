using System.Collections.Generic;

namespace HotelApp.Data.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
