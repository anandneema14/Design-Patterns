using CQRS.Models;
using CQRS.Repositories;

namespace CQRS.Commands;

public class EmployeeCommands : IEmployeeCommands
{
    private readonly IEmployeeCommandsRepository _commandsRepository;

    public EmployeeCommands(IEmployeeCommandsRepository commandsRepository)
    {
        _commandsRepository = commandsRepository;
    }
    public void SaveEmployeeData(Employee employee)
    {
        _commandsRepository.SaveEmployee(employee);
    }
}