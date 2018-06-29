using HotelApp.Data.Entities;

namespace HotelApp.Data.Repositories
{
    public interface ICouponRepository
    {
        Coupon GetCoupon(string couponCode);
    }
}
