using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;
using TDDSample.Mocks;
using TDDSample.Presenters;
using TDDSample.Presenters.UserControls;
using TDDSample.Presenters.Infrasructure;

namespace TDDSample.Tests
{
    [TestFixture]
    public class HeaderPresenterTests
    {
        [Test]
        public void Username_Returned_Is_CSmith()
        {
            IHeaderView view = new MockHeaderView();
            IEmployeeData data = new MockEmployeeData();

            var presenter = new HeaderPresenter(view, data);
            var userInfo = data.GetEmployeeListById(2);
                        
            foreach (var item in userInfo)
            {
                view.Username = item.Username;
            }
            
            Assert.AreEqual("CSmith", view.Username);
        }
        

    }
}
