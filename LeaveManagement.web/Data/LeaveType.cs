using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.web.Data
{
    public class LeaveType:BaseEntity
    {
      
        public int DefaultDays { get; set; }
        public string Name { get; set; }

    }
}
