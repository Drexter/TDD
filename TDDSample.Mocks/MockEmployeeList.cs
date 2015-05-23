using System.Collections.Generic;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;

namespace TDDSample.Mocks
{
    public class MockEmployeeData : IEmployeeData
    {
        public List<Employee> GetEmployeeList()
        {
            var empList = new List<Employee>();
            var emp1 = new Employee {EmployeeId = 1, FirstName = "Jane", LastName = "Doe"};
            emp1.FullName = string.Format("{0}, {1}", emp1.LastName, emp1.FirstName);
            empList.Add(emp1);

            return empList;
        }

       
    }
}
