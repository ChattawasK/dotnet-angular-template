using App.Application.DTOs.LeaveAllocation;
using MediatR;

namespace App.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand: IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}