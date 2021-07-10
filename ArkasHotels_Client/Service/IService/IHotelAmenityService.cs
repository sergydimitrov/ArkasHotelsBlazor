using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkasHotels_Client.Service.IService
{
    public interface IHotelAmenityService
    {
        public Task<IEnumerable<HotelAmenityDTO>> GetHotelAmenities();
    }
}
