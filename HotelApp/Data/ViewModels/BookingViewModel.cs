using HotelApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data.ViewModels
{
    public class BookingViewModel
    {
        public int RoomId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public IList<Room> Rooms { get; set; }
        public string CouponCode { get; set; }
    }
}
