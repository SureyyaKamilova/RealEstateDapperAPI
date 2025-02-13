﻿using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.EmployeeDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto employeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto employeeDto);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
