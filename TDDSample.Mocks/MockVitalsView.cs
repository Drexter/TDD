using System.Collections.Generic;
using TDDSample.Data.Model;
using TDDSample.Presenters;



namespace TDDSample.Mocks
{
    public class MockVitalsView : IVitalsView
    {
        public string Name { get; set; }

        public string SSN { get; set; }

        public List<Employee> EmployeeList { private get; set; }

        public string ErrorMessage { get; set; }

        public List<Employee> EmployeeGridList { private get; set; }
    }
}
