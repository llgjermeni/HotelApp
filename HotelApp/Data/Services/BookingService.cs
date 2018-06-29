using HotelApp.Data.Entities;
using HotelApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data.Services
{
    public class BookingService : IBookingService
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly ICouponRepository _couponRepository;

        public BookingService(IRoomsRepository roomsRepository, ICouponRepository couponRepository)
        {
            _roomsRepository = roomsRepository;
            _couponRepository = couponRepository;
        }
        public decimal CalculateBookingPrice(Booking booking)
        {
            var room = _roomsRepository.GetRoom(booking.RoomId);
            var numberOfNights = (booking.CheckOutDate - booking.CheckInDate).Days;
            var price = room.Rate * numberOfNights;

            if (string.IsNullOrEmpty(booking.CouponCode))
            {
                return price;
            }

            var discount = _couponRepository.GetCoupon(booking.CouponCode).PercentageDiscount;

            price = price - (price * discount / 100);

            return price;
        }
    }
}
