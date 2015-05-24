using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;
using TDDSample.Presenters;
using TDDSample.Presenters.Infrasructure;

namespace TDDSample.Web
{
    /// <summary>
    /// Please create a test before doing any modifications.
    /// </summary>
    public partial class VitalsView : System.Web.UI.Page, IVitalsView
    {
        private VitalsPresenter _presenter;
        
        /// <summary>
        /// Injected property
        /// </summary>
        public IEmployeeData Data { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new VitalsPresenter(this, Data);
            
            if (!Page.IsPostBack)
            {
                _presenter.GetEmployeeList();
                _presenter.GetEmployeeGridList();
            }
        }

        public string Name
        {
            get { return nameTextbox.Text; }
            set { nameTextbox.Text = value; }
        }

        public string SSN
        {
            get { return ssnTextbox.Text; }
            set { ssnTextbox.Text = value; }
        }

        public string ErrorMessage
        {
            get { return errorMessageLabel.Text; }
            set { errorMessageLabel.Text = value; }
        }

        public List<Employee> EmployeeList
        {
            set
            {
                ddlTest.DataSource = value;
                ddlTest.DataTextField = "FullName";
                ddlTest.DataValueField = "EmployeeId";
                ddlTest.DataBind();
            }
        }

        public List<Employee> EmployeeGridList
        {
            set
            {
                grdViewEmployee.DataSource = value;
                grdViewEmployee.DataBind();
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (_presenter.OnOk() == true)
                Response.Redirect("ThankYou.aspx");
        }

        protected void btnGetUser_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(ddlTest.SelectedValue);
            _presenter.GetEmployeeGridListById(userId);
        }
    }
}