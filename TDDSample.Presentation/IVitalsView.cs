using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSample.Data.Model;

namespace TDDSample.Presenters
{
    public interface IVitalsView
    {
        string Name { get; set; }
        string SSN { get; set; }
        string ErrorMessage { get; set; }
        List<Employee> EmployeeList { set; }
        List<Employee> EmployeeGridList { set; }
    }
}
