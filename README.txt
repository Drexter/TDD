The purpose of this project is to create a standard way of building projects in ASP.NET Web Forms.  I've worked in many projects and seen how quickly it can get dis-organized such has having the data layer mixed in with the presentation layer on the web form then having another separate DAL layer in a separate file.  I do understand it may be due to tight time constraints but a common best practice will make maintenance easier in the long run.

The TDDSample project is broken down into the following projects.  This should be the mandatory projects required to create the web application.  Create other projects as needed.
TDDSample.Data - contains the data layer that will make calls to the database
TDDSample.Mocks - contains the mocked data for the unit tests.  This is done for performance reasons so that testing can be done against the TDDSample.Presenters. 
TDDSample.Presenters - contains essentially the code behind of the web application.
TDDSample.Tests - contains the unit test for presenters
TDDSample.Web - contains the web applicaiton that utilizes the TDDSample.Data and TDDSample.Presenters projects.

Project Setup
	|_Data
		|_Infrastructure
			|_Interface classes
		|_Model
		|_<Model>Data.cs
	|_Mocks
		|_MockData
		|_Mocked Views
	|_Presenters
		|_Infrastructure
			|_Interface classes
	|_Tests - Stricty test the code base.  This should only be testing with mocked data.  Use the 
		|_Program.cs - Can be used to verify test using instance and using debugger.
		|_<Item_To_Be_Tested>Tests.cs
	|_Integration Tests
		|_<Database_Calls_To_Be_Tested>Test.cs
	|_Web
		|_Web Application Files

	When you use this project be sure to always start your testing first by beginning in the <Project>.Tests first. On top of that, mock any data that comes to mind so that you can run regression on the unit tests. Run the integration test to make sure that the database is working as it should such as cascade deletes, identity generations...etc. So in general the order should be:

	1. TDDSample.Tests - Create your unit tests.
	2. TDDSample.Mocks - Add mocks as needed when creating your tests.
	3. TDDSample.Presenters and TDDSample.Data projects - Modify these projects to get the test to pass.
	4. TDDSample.Integration.Tests - Run the integration tests to verify db functionality.  Basically will verify the regular tests.