using CQRS.DTOs;

namespace CQRS.Queries;

public interface IEmployeeQueries
{
    EmployeeDTO FindbyId(int employeeId);
}