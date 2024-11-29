using Dapper;
using RealEstateDapperAPI.DTOS.ContactDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;
        public ContactRepository(Context context)
        {
            _context = context;
        }
        public void CreateContact(CreateContactDto contactDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultContactDto>> GetAllContactAsync()
        {
            string query = "Select * From Contact";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultContactDto>(query);

                return values.ToList();
            }
        }

        public Task<GetByIdContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultContactDto>> GetLastFourContactAsync()
        {
            string query = "Select Top(4) *From Contact Order By ContactId Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultContactDto>(query);

                return values.ToList();
            }
        }
    }
}
