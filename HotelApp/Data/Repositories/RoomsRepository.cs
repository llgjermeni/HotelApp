using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Data.Entities;

namespace HotelApp.Data.Repositories
{
    public class RoomsRepository : IRoomsRepository
    {
        private readonly IList<Room> roomList = new List<Room>
        {
            new Room
            {
                Id=1,
                Name="Winchester",
                Rate=200
            },
            new Room
            {
                Id=2,
                Name="Piccadilly",
                Rate=250
            }
        };
        public Room GetRoom(int id)
        {
            return roomList.SingleOrDefault(r => r.Id == id);
        }

        public IList<Room> GetRooms()
        {
            return roomList;
        }
    }
}
