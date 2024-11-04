using Dapper;
using RealEstateDapperAPI.DTOS.BottomGridDtos;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.ServiceDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }
        public async void CreateBottomGrid(CreateBottomGridDto bottomGridDto)
        {
            string query = "Insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";

            var parameters = new DynamicParameters();
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@description", bottomGridDto.Description);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridId=@bottomGridId";

            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);

                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "Select *From BottomGrid Where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();

            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto)
        {
            string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description Where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", bottomGridDto.BottomGridId);
            parameters.Add("@serviceName", bottomGridDto.Icon);
            parameters.Add("@serviceName", bottomGridDto.Title);
            parameters.Add("@serviceName", bottomGridDto.Description);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
