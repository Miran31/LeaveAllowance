using AutoMapper;
using LeaveAllowance.Application.LeaveTypes.Dtos;
using LeaveAllowance.Domain.LeaveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAllowance.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveTypeDto, LeaveTy>().ReverseMap();
        }
    }
}
