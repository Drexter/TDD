The TDDSample project is broken down into the following projects.
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
	|_Tests
		|_Program.cs - Can be used to verify test using instance and using debugger.
		|_<Item_To_Be_Tested>Tests.cs
	|_Web
