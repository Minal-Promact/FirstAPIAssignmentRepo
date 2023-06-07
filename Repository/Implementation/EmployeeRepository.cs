using FirstAPIAssignmentRepo.Data;
using FirstAPIAssignmentRepo.Model;
using FirstAPIAssignmentRepo.Repository.Interface;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Reflection;

namespace FirstAPIAssignmentRepo.Repository.Implementation
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly EmployeeAPIDBContext dbContext;

        public EmployeeRepository(EmployeeAPIDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await dbContext.Employee.ToListAsync();
        }

        public async Task<Employee> GetEmployeesById(Guid empId)
        {
            return await dbContext.Employee.FirstOrDefaultAsync(e => e.Id == empId);
        }

        public async Task<Employee> CheckEmailExistsInEmployee(string Email)
        {            
            return await dbContext.Employee.FirstOrDefaultAsync(a => a.Email == Email);
        }

        public async Task<Employee> AddEmployee(EmployeeRequest addEmployeeRequest)
        {
            var employee = new Employee()
            {
                FullName = addEmployeeRequest.FullName,
                Birthdate = addEmployeeRequest.Birthdate,
                Address = addEmployeeRequest.Address,
                Age = addEmployeeRequest.Age,
                Designation = addEmployeeRequest.Designation,
                Salary = addEmployeeRequest.Salary,
                Email = addEmployeeRequest.Email

            };

            var result = await dbContext.Employee.AddAsync(employee);
            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> UpdateEmployee(Employee emp,EmployeeRequest updateEmployeeRequest)
        {
            emp.FullName = updateEmployeeRequest.FullName;
            emp.Birthdate = updateEmployeeRequest.Birthdate;
            emp.Address = updateEmployeeRequest.Address;
            emp.Age = updateEmployeeRequest.Age;
            emp.Designation = updateEmployeeRequest.Designation;
            emp.Salary = updateEmployeeRequest.Salary;
            emp.Email = updateEmployeeRequest.Email;
            var result = dbContext.Update(emp);
            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> PatchEmployee(Employee emp, JsonPatchDocument patchDataRequest)
        {
            patchDataRequest.ApplyTo(emp);
            var result = dbContext.Update(emp);
            await dbContext.SaveChangesAsync();
            return result.Entity;
        }        

        public void DeleteEmployee(Employee emp)
        {
            dbContext.Remove(emp);
            dbContext.SaveChangesAsync();
        }
    }
}
