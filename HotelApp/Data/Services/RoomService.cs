using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Data.Entities;
using HotelApp.Data.Repositories;

namespace HotelApp.Data.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomsRepository _roomsRepository;

        public RoomService(IRoomsRepository roomsRepository)
        {
            _roomsRepository = roomsRepository;
        }
        public IList<Room> GetAllRooms()
        {
            return _roomsRepository.GetRooms();
        }
    }
}
