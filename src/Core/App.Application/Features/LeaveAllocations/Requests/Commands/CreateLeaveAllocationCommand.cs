using App.Application.DTOs.LeaveAllocation;
using App.Application.Responses;
using MediatR;

namespace App.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand: IRequest<BaseCommandResponse>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}