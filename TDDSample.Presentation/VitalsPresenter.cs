using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;
using TDDSample.Presenters.Infrasructure;

namespace TDDSample.Presenters
{
    public class VitalsPresenter
    {
        public const string ERROR_MESSAGE_BAD_SSN = "Bad SSN.";
        public const string ERROR_MESSAGE_BAD_NAME = "Bad name.";
        public const string ERROR_MESSAGE_BAD_EMPLOYEE_ID = "Please select a user";
        private readonly IVitalsView _view;
        private readonly IEmployeeData _data;

        public VitalsPresenter(IVitalsView view)
        {
            _view = view;
        }

        public VitalsPresenter(IVitalsView view, IEmployeeData data)
        {
            _view = view;
            _data = data;
        }

        public bool OnOk()
        {
            if (IsValidName() == false)
            {

                _view.ErrorMessage = ERROR_MESSAGE_BAD_NAME;
                return false;
            }

            if (IsValidSSN() == false)
            {
                _view.ErrorMessage = ERROR_MESSAGE_BAD_SSN;
                return false;
            }

            // All is well, do something...

            return true;
        }

        public void RefreshGridView()
        {
            if (!IsValidEmployeeId())
            {
                _view.ErrorMessage = ERROR_MESSAGE_BAD_EMPLOYEE_ID;
            }
            else
            {
                GetEmployeeGridListById(Convert.ToInt32(_view.EmployeeId));
                _view.ErrorMessage = string.Empty;
            }
        }

        private bool IsValidName()
        {
            return _view.Name.Length > 0;
        }

        private bool IsValidSSN()
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(_view.SSN, pattern);
        }
        
        public bool IsValidEmployeeId()
        {
            return _view.EmployeeId.Length > 0;
        }

        public List<Employee> GetEmployeeList()
        {
            return _view.EmployeeList = _data.GetEmployeeList();
        }

        public List<Employee> GetEmployeeGridList()
        {
            return _view.EmployeeGridList = _data.GetEmployeeList();
        }

        public List<Employee> GetEmployeeGridListById(int Id)
        {
            return _view.EmployeeGridList = _data.GetEmployeeListById(Id);
        }
    }
}
