using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSample.Data.Model;

namespace TDDSample.Data.Data
{
    public class EmployeeData : IEmployeeData
    {
        public List<Employee> GetEmployeeList()
        {
            var empList = new List<Employee>();
            var emp1 = new Employee {EmployeeId = 1, FirstName = "John", LastName = "Doe"};
            emp1.FullName = string.Format("{0}, {1}", emp1.LastName, emp1.FirstName);
            empList.Add(emp1);
            return empList;
        }
    }
}
