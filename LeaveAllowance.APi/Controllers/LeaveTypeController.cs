using LeaveAllowance.Application.LeaveType;
using LeaveAllowance.Application.LeaveTypes.Dtos;
using LeaveAllowance.Domain.LeaveTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveAllowance.APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly ILeaveTypeService _leaveTypeService;
        public LeaveTypeController(ILeaveTypeService leaveTypeService )
        {
            _leaveTypeService = leaveTypeService;
            
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(LeaveTypeDto leaveTypeDto)
        {
            LeaveTypeDto leaveTypeDto1 = _leaveTypeService.Add(leaveTypeDto);

            return Ok(leaveTypeDto1);
        }


        [HttpGet]
        [Route("[action]")]
        public IActionResult Getall()
        {
            IEnumerable<LeaveTy> leavetypes = _leaveTypeService.Getall();
            return Ok(leavetypes);
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            _leaveTypeService.Delete(id);
            return Ok();
        }


        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult Update(int id, LeaveTypeDto leaveTypeDto)
        {
            if(id != leaveTypeDto.Id)
            {
                return BadRequest();
            }
            LeaveTypeDto ledto =  _leaveTypeService.Update(leaveTypeDto);
            return Ok(ledto);
        }

    }
}
