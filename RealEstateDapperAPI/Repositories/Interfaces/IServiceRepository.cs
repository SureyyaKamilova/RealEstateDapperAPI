using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.ServiceDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto serviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto serviceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
