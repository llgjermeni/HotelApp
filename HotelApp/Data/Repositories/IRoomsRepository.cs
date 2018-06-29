using HotelApp.Data.Entities;
using System.Collections.Generic;

namespace HotelApp.Data.Repositories
{
    public interface IRoomsRepository
    {
        IList<Room> GetRooms();
        Room GetRoom(int id);
    }
}
