﻿using RealEstate_Dabber_Api.Dtos.PopularLocationDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {

            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();

            }
        }
    }
}
