using CQRS.Models;

namespace CQRS.Repositories;

public class EmployeeQueriesRepository : IEmployeeQueriesRepository
{
    public Employee GetById(int employeeId)
    {
        return new Employee()
        {
            Id = 100,
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(2020, 01, 01),
            Street = "123 Main Street",
            City = "London",
            PostalCode = "12345"
        };
    }
}