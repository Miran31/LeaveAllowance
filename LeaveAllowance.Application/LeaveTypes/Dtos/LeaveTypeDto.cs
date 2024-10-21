using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAllowance.Application.LeaveTypes.Dtos
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        public string LeaveType { get; set; }
        public int Duration { get; set; }
    }
}
