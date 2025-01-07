using CQRS.Models;

namespace CQRS.Repositories;

public interface IEmployeeCommandsRepository
{ 
    void SaveEmployee(Employee employee);
}