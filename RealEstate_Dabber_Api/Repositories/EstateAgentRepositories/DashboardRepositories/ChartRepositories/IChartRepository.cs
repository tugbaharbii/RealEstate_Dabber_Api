using RealEstate_Dabber_Api.Dtos.ChartDtos;

namespace RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
       Task< List<ResultChartDto>> Get5CityForChart();
    }
}
