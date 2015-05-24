using System.Collections.Generic;
using NUnit.Framework;
using TDDSample.Data.Infrastructure;
using TDDSample.Data.Model;
using TDDSample.Mocks;
using TDDSample.Presenters;
using TDDSample.Presenters.Infrasructure;


namespace TDDSample.Tests
{
    [TestFixture]
    public class VitalsControllerTests
    {
        [Test]
        public void Name_And_SSN_Data_Are_Valid()
        {
            var view = new MockVitalsView();
            var controller = new VitalsPresenter(view);            

            view.Name = "John Doe";
            view.SSN = "123-45-6789";

            Assert.IsTrue(controller.OnOk());
        }

        [Test]
        public void Name_And_SSN_Data_Is_Not_Valid()
        {
            var view = new MockVitalsView();
            var controller = new VitalsPresenter(view);

            view.Name = "";
            view.SSN = "123-45-6789";
            Assert.IsFalse(controller.OnOk());
            
            view.Name = "John Doe";
            view.SSN = "";
            Assert.IsFalse(controller.OnOk());            
        }

        [Test]
        public void EmployeeList_Has_Data()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();
            
            var presenter = new VitalsPresenter(view, data);

            Assert.IsTrue(presenter.GetEmployeeList().Count > 0);
        }

        [Test]
        public void EmployeeGridList_Has_Data()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();

            var presenter = new VitalsPresenter(view, data);

            Assert.IsTrue(presenter.GetEmployeeGridList().Count > 0);
        }

        [Test]
        public void Search_EmployeeList_By_Id_Returns_Charles_Smith()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();

            var presenter = new VitalsPresenter(view, data);

            List<Employee> emp =  presenter.GetEmployeeGridListById(2);

            string fullName = string.Empty;
            foreach(var item in emp)
            {
                fullName = item.FullName;
            }

            Assert.AreEqual("Smith, Charles", fullName);
        }
    }
}
