using Dapper;
using RealEstateDapperAPI.DTOS.ToDoListDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;
        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public async void CreateToDoList(CreateToDoListDto toDoListDto)
        {
            string query = "Insert into Service (Description, ToDoStatus) values (@description,@toDoStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("@description", toDoListDto.Description);
            parameters.Add("@toDoStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public void DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoListAsync()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);

                return values.ToList();
            }
        }

        public Task<GetByIdToDoList> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateToDoList(UpdateToDoListDto toDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
