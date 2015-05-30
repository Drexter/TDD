using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;
using TDDSample.Presenters.Infrasructure;
using TDDSample.Presenters.UserControls;

namespace TDDSample.Web.UserControls
{
    public partial class HelloWorld : System.Web.UI.UserControl, IHeaderView
    {
        private HeaderPresenter _presenter;

        /// <summary>
        /// Injected property
        /// </summary>
        public IEmployeeData Data { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new HeaderPresenter(this, Data);
            
            if (!Page.IsPostBack)
            {
               _presenter.Initialize();
            }
        }

        public string Username
        {
            get
            {
                return lblUsername.Text;
            }
            set
            {
                lblUsername.Text = value;
            }
        }
    }
}