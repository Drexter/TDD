using System.Collections.Generic;
using TDDSample.Data.Model;

namespace TDDSample.Presenters.Infrasructure
{
    public interface IVitalsView
    {
        string Name { get; set; }
        string SSN { get; set; }
        string ErrorMessage { get; set; }
        string EmployeeId { get; set; }
        List<Employee> EmployeeList { set; }
        List<Employee> EmployeeGridList { set; }
    }
}
