using Dapper;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.WhoWeAreDetailDtos;
using RealEstateDapperAPI.DTOS.WhoWeAreDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;
        public WhoWeAreRepository(Context context)
        {
            _context= context;
            
        }
        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto whoWeAreDetailDto)
        {
            string query = "Insert into WhoWeAreDetail (Title,Subtitle,Description1,Description2) Values (@title,@subtitle,@description1,@description2)";

            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetailDto.Title);
            parameters.Add("@subtitle", whoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", whoWeAreDetailDto.Description1);
            parameters.Add("@description2", whoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete From WhoWeAreDetail Where WhoWeAreDetailId=@whoWeAreDetailId";

            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);

                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {
            string query = "Select *From WhoWeAreDetail Where WhoWeAreDetailId=@whoWeAreDetailId";
            var parameters = new DynamicParameters();

            parameters.Add("@whoWeAreDetailId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto whoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@title, Subtitle=@subtitle,Description1=@description1,Description2=@description2 Where WhoWeAreDetailId=@whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", whoWeAreDetailDto.WhoWeAreDetailId);
            parameters.Add("@title", whoWeAreDetailDto.Title);
            parameters.Add("@subtitle", whoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", whoWeAreDetailDto.Description1);
            parameters.Add("@description2", whoWeAreDetailDto.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
