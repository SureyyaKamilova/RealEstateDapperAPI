using RealEstateDapperAPI.DTOS.BottomGridDtos;
using RealEstateDapperAPI.DTOS.CatagoryDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto bottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
