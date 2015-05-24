using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            var emp2 = new Employee { EmployeeId = 2, FirstName = "Charles", LastName = "Smith" };
            emp2.FullName = string.Format("{0}, {1}", emp2.LastName, emp2.FirstName);
            empList.Add(emp2);

            return empList;
        }

        public List<Employee> GetEmployeeListById(int Id)
        {
            var empList = new List<Employee>();

            var emp1 = new Employee { EmployeeId = 1, FirstName = "Jane", LastName = "Doe" };
            emp1.FullName = string.Format("{0}, {1}", emp1.LastName, emp1.FirstName);
            empList.Add(emp1);

            var emp2 = new Employee { EmployeeId = 2, FirstName = "Charles", LastName = "Smith" };
            emp2.FullName = string.Format("{0}, {1}", emp2.LastName, emp2.FirstName);
            empList.Add(emp2);

            var result = empList.Where(n => n.EmployeeId == Id);

            return result.ToList();
        }
    }
}
