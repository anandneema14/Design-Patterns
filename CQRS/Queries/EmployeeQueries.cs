using CQRS.DTOs;
using CQRS.Repositories;

namespace CQRS.Queries;

public class EmployeeQueries : IEmployeeQueries
{
    private readonly IEmployeeQueriesRepository _queriesRepository;

    public EmployeeQueries(IEmployeeQueriesRepository queriesRepository)
    {
        _queriesRepository = queriesRepository;
    }
    
    public EmployeeDTO FindbyId(int employeeId)
    {
        var emp=_queriesRepository.GetById(employeeId);
        return new EmployeeDTO()
        {
            Id = emp.Id,
            FullName = emp.FirstName + " " + emp.LastName,
            Address = emp.Street + ", " + emp.City + " " + emp.PostalCode,
            Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays / 365)))
        };
    }
}