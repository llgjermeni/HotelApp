using HotelApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data.Services
{
    public interface IRoomService
    {
        IList<Room> GetAllRooms();
    }
}
