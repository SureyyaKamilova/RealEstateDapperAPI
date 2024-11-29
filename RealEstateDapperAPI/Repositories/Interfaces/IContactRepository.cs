using RealEstateDapperAPI.DTOS.ContactDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<ResultContactDto>> GetLastFourContactAsync();
        void CreateContact(CreateContactDto contactDto);
        void DeleteContact(int id);
        Task<GetByIdContactDto> GetContact(int id);
    }
}
