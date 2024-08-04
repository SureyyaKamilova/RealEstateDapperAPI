using RealEstateDapperAPI.DTOS.BottomGridDtos;
using RealEstateDapperAPI.DTOS.PopularLocationDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        //void CreatePopularLocation(CreatePopularLocationDto poplularLocationDto);
        //void DeletePopularLocation(int id);
        //void UpdatePopularLocation(UpdatePopularLocationDto poplularLocationDto);
        //Task<GetPopularLocationDto> GetPopularLocation(int id);
    }
}
