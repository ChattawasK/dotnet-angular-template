using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Application.DTOs.LeaveType;
using App.Application.Features.LeaveTypes.Requests.Commands;
using App.Application.Features.LeaveTypes.Requests.Queries;
using App.Application.Responses;
using App.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
//using App.Api.Models;

namespace App.Api.Controllers {
    
    [Route ("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase {
        private readonly IMediator _mediator;
        public LeaveTypesController (IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<LeaveTypeDto>>> Get() {
            var leaveType = await _mediator.Send(new GetLeaveTypeListRequest());
            return Ok(leaveType);
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<LeaveTypeDto>> GetById (int id) {
            var leaveType = await _mediator.Send(new GetLeaveTypeDetailRequest{Id = id});
            return Ok(leaveType);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post ([FromBody]CreateLeaveTypeDto model) {
            var command = new CreateLeaveTypeCommand{LeaveTypeDto = model};
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> PutTModel (LeaveTypeDto model) {
            var command = new UpdateLeaveTypeCommand {LeaveTypeDto = model};
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult> DeleteTModelById (int id) {
            var command = new DeleteLeaveTypeCommand {Id = id};
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
