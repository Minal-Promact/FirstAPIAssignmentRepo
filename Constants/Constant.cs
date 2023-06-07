using FirstAPIAssignmentRepo.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstAPIAssignmentRepo.Constants
{
    public static class Constant
    {
        public const string Route = "api/[controller]/";
        public const string GetEmployees = "GetEmployees";
        public const string GetEmployeeById = "GetEmployeeById";
        public const string AddEmployee = "AddEmployee";
        public const string UpdateEmployee = "UpdateEmployee";
        public const string PatchEmployee = "PatchEmployee";
        public const string DeleteEmployee = "DeleteEmployee";

        public const string RecordNotFound = "Record not found..";
        public const string CouldNotFetchEmployeeData = "Could not fetch employee data.";
        public const string EnterEmployeeId = "Enter EmployeeId";
        public const string TheKeyDoesNotExist = "The key does not exist";
        public const string IncorrectRequest = "Incorrect Request";
        public const string TheKeyAlreadyExists = "The key already exists";
        public const string TheRecordAlreadyExists = "The Record already exists";
    }
}
