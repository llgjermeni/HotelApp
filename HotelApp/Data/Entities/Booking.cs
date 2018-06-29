using System;

namespace HotelApp.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomId { get; set; }
        public string CouponCode { get; set; }
    }
}
