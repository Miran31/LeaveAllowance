using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveAllowance.Application.LeaveTypes.Dtos;
using LeaveAllowance.Domain.LeaveTypes;

namespace LeaveAllowance.Application.LeaveType
{
    public interface ILeaveTypeService
    {
        LeaveTypeDto Get(int id);
        LeaveTypeDto Update(LeaveTypeDto entity);
        void Delete(int id);
        LeaveTypeDto Add(LeaveTypeDto entity);
        IEnumerable<LeaveTy> Getall();

    }
}
