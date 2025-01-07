using CQRS.Models;

namespace CQRS.Repositories;

public interface IEmployeeQueriesRepository
{
    Employee GetById(int employeeId);
}