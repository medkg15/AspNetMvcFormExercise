using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcData.Leads
{
    /// <summary>
    /// A mock implementation of the ILeadHandler, that does nothing with the lead information.
    /// Alternative implementations might send an email, write to a database, call a web service, etc.
    /// </summary>
    public class MockLeadHandler : ILeadHandler
    {
        public void Handle(CreateLead lead)
        {
            // no-op
        }
    }
}
