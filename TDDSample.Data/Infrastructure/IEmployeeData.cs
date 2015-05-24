using System.Collections.Generic;
using TDDSample.Data.Model;

namespace TDDSample.Data.Infrastructure
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployeeList();
        List<Employee> GetEmployeeListById(int Id);
    }
}
