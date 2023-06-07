using FirstAPIAssignmentRepo.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPIAssignmentRepo.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeesById(Guid empId);
        Task<Employee> CheckEmailExistsInEmployee(string Email);
        Task<Employee> AddEmployee(EmployeeRequest addEmployeeRequest);
        Task<Employee> UpdateEmployee(Employee emp, EmployeeRequest updateEmployeeRequest);
        Task<Employee> PatchEmployee(Employee emp, JsonPatchDocument patchDataRequest);
        void DeleteEmployee(Employee emp);        

    }
}
