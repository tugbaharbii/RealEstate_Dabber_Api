﻿using RealEstate_Dabber_Api.Dtos.ChartDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;

        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> Get5CityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Product Group By city order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();

            }
        }
    }
}
