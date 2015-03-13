using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSample.Data.Model;

namespace TDDSample.Data.Data
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployeeList();
    }
}
