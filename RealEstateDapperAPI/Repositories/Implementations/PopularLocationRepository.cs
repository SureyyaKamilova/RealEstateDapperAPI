using Dapper;
using Microsoft.IdentityModel.Tokens;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.PopularLocationDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;
        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async void CreatePopularLocation(CreatePopularLocationDto poplularLocationDto)
        {
            string query = "Insert into PopularLocation (CityName,ImageUrl) values (@cityName,@imageUrl)";

            var parameters = new DynamicParameters();
            parameters.Add("@cityName", poplularLocationDto.CityName);
            parameters.Add("@imageUrl", poplularLocationDto.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {
            string query = "Delete From PopularLocation Where LocationId=@locationId";

            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<GetPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select * From PopularLocation Where LocationId=@locationId";
            var parameters = new DynamicParameters();

            parameters.Add("@locationId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetPopularLocationDto>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDto poplularLocationDto)
        {
            string query = "Update PopularLocation Set CityName=@cityName,ImageUrl=@imageUrl Where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", poplularLocationDto.LocationId);
            parameters.Add("@cityName", poplularLocationDto.CityName);
            parameters.Add("@imageUrl", poplularLocationDto.ImageUrl);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
