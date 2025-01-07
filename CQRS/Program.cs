using CQRS.Commands;
using CQRS.Queries;
using CQRS.Repositories;

namespace CQRS;

class Program
{
    static void Main(string[] args)
    {
        var employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());
        employeeCommand.SaveEmployeeData(new Models.Employee
        {
            Id = 200,
            FirstName = "John",
            LastName = "Doe",
            Street = "123 Main Street",
            City = "London",
            DateOfBirth = new DateTime(1985, 9, 9),
            PostalCode = "12345"
        });
        
        Console.WriteLine($"Employee Data Stored");

        var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
        var employee = employeeQuery.FindbyId(100);
        Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}");
        Console.ReadKey();
    }
}