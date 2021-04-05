using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagementAspBlazor.Data
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public DateTime TimeStart { get; set; }
        public string Address { get; set; }
        public DateTime DateInit { get; set;}

    }
}
