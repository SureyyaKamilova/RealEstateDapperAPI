using RealEstateDapperAPI.DTOS.ToDoListDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto toDoListDto);
        void DeleteToDoList(int id);
        void UpdateToDoList(UpdateToDoListDto toDoListDto);
        Task<GetByIdToDoList> GetToDoList(int id);
    }
}
