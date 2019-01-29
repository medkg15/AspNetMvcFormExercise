using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcData.Leads
{
    public interface ILeadHandler
    {
        void Handle(CreateLead lead);
    }
}
