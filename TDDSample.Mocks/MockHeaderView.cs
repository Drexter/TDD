using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSample.Presenters.Infrasructure;

namespace TDDSample.Mocks
{
    public class MockHeaderView : IHeaderView
    {
        public string Username { get; set; }
    }
}
