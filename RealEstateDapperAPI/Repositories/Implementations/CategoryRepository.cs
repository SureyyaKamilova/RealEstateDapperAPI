﻿using Dapper;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "Insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete From Category Where CategoryId=@categoryId";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);

                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "Select *From Category Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();

            parameters.Add("@categoryId", id);

            using (var  connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", categoryDto.CategoryId);
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
