using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAllowance.Domain.LeaveTypes
{
    public class LeaveTy
    {
        public int Id { get; set; }
        public string LeaveType { get; set; }
        public int Duration { get; set; }
    }
}
