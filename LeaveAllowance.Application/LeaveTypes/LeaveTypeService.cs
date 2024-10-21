using AutoMapper;
using LeaveAllowance.Application.LeaveType;
using LeaveAllowance.Application.LeaveTypes.Dtos;
using LeaveAllowance.Domain.LeaveTypes;
using LeaveAllowance.EntityFrameworkCore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAllowance.Application.LeaveTypes
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public LeaveTypeService(AppDbContext appDbContext, IMapper mapper)
        {
            _context = appDbContext;
            _mapper = mapper;
            
        }
        public LeaveTypeDto Add(LeaveTypeDto entity)
        {
            LeaveTy leaveTy = _mapper.Map<LeaveTy>(entity); 
            _context.leaveTypes.Add(leaveTy);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            LeaveTy leaveTy = _context.leaveTypes.FirstOrDefault(u => u.Id == id);
            string lowerType = leaveTy.LeaveType.ToLower();
            if(lowerType.Contains("annaul") || lowerType.Contains("sick"))
            {
                throw new InvalidOperationException("You cannot delete this leave type.");
            }
            _context.Remove(leaveTy);
            _context.SaveChanges();
        }

        public LeaveTypeDto Get(int id)
        {
            LeaveTy leaveTy = _context.leaveTypes.FirstOrDefault(u => u.Id == id);

            LeaveTypeDto leaveTypeDto = _mapper.Map<LeaveTypeDto>(leaveTy);
            return leaveTypeDto;
        }

        public IEnumerable<LeaveTy> Getall()
        {
            IEnumerable<LeaveTy> leaveTies = _context.leaveTypes.ToList();
            return leaveTies;
        }

        public LeaveTypeDto Update(LeaveTypeDto entity)
        {
            LeaveTy leaveTy = _context.leaveTypes.FirstOrDefault(u => u.Id == entity.Id);
            leaveTy.LeaveType = entity.LeaveType;
            leaveTy.Duration = entity.Duration;

            _context.SaveChanges();

            return _mapper.Map<LeaveTypeDto>(entity);
        }
    }
}
