using App.Application.DTOs.LeaveAllocation;
using MediatR;

namespace App.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationCommand: IRequest<Unit>
    {
        public int Id { get; set; }
    }
}