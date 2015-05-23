The TDDSample project is broken down into the following projects.
TDDSample.Data - contains the data layer that will make calls to the database
TDDSample.Mocks - contains the mocked data for the unit tests.  This is done for performance reasons so that testing can be done against the TDDSample.Presenters. 
TDDSample.Presenters - contains essentially the code behind of the web application.
TDDSample.Tests - contains the unit test for presenters
TDDSample.Web - contains the web applicaiton that utilizes the TDDSample.Data and TDDSample.Presenters projects.