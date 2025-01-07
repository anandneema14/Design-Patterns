using CQRS.Models;

namespace CQRS.Commands;

public interface IEmployeeCommands
{
    void SaveEmployeeData(Employee employee);
}