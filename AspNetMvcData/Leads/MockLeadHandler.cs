using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcData.Leads
{
    public class MockLeadHandler : ILeadHandler
    {
        public void Handle(CreateLead lead)
        {
            // no-op
        }
    }
}
