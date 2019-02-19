using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvc.Models
{
    public class Lead
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}