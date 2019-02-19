using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcData.Leads
{
    /// <summary>
    /// Responsible for processing a sales lead submission.
    /// </summary>
    public interface ILeadHandler
    {
        /// <summary>
        /// Handle the create lead submission.
        /// </summary>
        /// <param name="lead"></param>
        void Handle(CreateLead lead);
    }
}
