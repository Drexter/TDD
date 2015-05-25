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
            var presenter = new VitalsPresenter(view);            

            view.Name = "John Doe";
            view.SSN = "123-45-6789";

            Assert.IsTrue(presenter.OnOk());
        }

        [Test]
        public void Name_And_SSN_Data_Is_Not_Valid()
        {
            var view = new MockVitalsView();
            var presenter = new VitalsPresenter(view);

            view.Name = "";
            view.SSN = "123-45-6789";
            Assert.IsFalse(presenter.OnOk());
            
            view.Name = "John Doe";
            view.SSN = "";
            Assert.IsFalse(presenter.OnOk());            
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

        [Test]
        public void DropDownList_Value_Is_Not_Valid()
        {
            var view = new MockVitalsView();
            var controller = new VitalsPresenter(view);

            view.EmployeeId = "";
            
            Assert.IsFalse(controller.IsValidEmployeeId());
        }

        [Test]
        public void Display_Message_When_No_User_Is_Selected_In_Dropdown()
        {
            var view = new MockVitalsView();
            var controller = new VitalsPresenter(view);
            
            view.EmployeeId = string.Empty;
            controller.RefreshGridView();

            Assert.AreEqual(view.ErrorMessage, VitalsPresenter.ERROR_MESSAGE_BAD_EMPLOYEE_ID);
        }

        [Test]
        public void Display_No_Message_When_User_Is_Selected_In_Dropdown()
        {
            var view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();
            var controller = new VitalsPresenter(view, data);
            
            view.EmployeeId = "1";
            controller.RefreshGridView();

            Assert.AreEqual(view.ErrorMessage, string.Empty);
        }

        [Test]
        public void Initialize_View()
        {
            var view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();
            var presenter = new VitalsPresenter(view, data);

            presenter.Initialize();

            Assert.Greater(presenter.GetEmployeeGridList().Count, 1);

        }
    }
}
