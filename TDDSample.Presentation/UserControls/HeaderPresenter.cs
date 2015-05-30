using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSample.Presenters.Infrasructure;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;

namespace TDDSample.Presenters.UserControls
{
    public class HeaderPresenter
    {
        private readonly IHeaderView _view;
        private readonly IEmployeeData _data;
        public HeaderPresenter(IHeaderView view, IEmployeeData data )
        {
            _view = view;
            _data = data;
        }

        public void Initialize()
        {
            var userInfo = _data.GetEmployeeListById(2);

            foreach (var item in userInfo)
            {
                _view.Username = item.Username;
            }
        }


    }
}
