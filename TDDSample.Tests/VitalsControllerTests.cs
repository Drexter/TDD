using NUnit.Framework;
using TDDSample.Data.Infrastructure;
using TDDSample.Mocks;
using TDDSample.Presenters;
using TDDSample.Presenters.Infrasructure;


namespace TDDSample.Tests
{
    [TestFixture]
    public class VitalsControllerTests
    {
        [Test]
        public void Test_Name_And_SSN_Data_Is_Valid()
        {
            var view = new MockVitalsView();
            var controller = new VitalsPresenter(view);            

            view.Name = "John Doe";
            view.SSN = "123-45-6789";

            Assert.IsTrue(controller.OnOk());
        }

        [Test]
        public void Test_Name_And_SSN_Data_Is_Not_Valid()
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
        public void Test_EmployeeList_Has_Data()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();
            
            var presenter = new VitalsPresenter(view, data);

            Assert.IsTrue(presenter.GetEmployeeList().Count > 0);
        }

        [Test]
        public void Test_EmployeeList_Has_FullName_Of_DoeJane()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();
            
            var presenter = new VitalsPresenter(view, data);
            var empList = presenter.GetEmployeeList();

            string fullName = string.Empty;
            foreach (var emp in empList)
            {
                fullName = emp.FullName;
            }

            Assert.AreEqual("Doe, Jane", fullName);
        }

        [Test]
        public void Test_EmployeeGridList_Has_Data()
        {
            IVitalsView view = new MockVitalsView();
            IEmployeeData data = new MockEmployeeData();

            var presenter = new VitalsPresenter(view, data);

            Assert.IsTrue(presenter.GetEmployeeGridList().Count > 0);
        }
    }
}
