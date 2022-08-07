using App.Application.DTOs;
using App.Application.DTOs.LeaveAllocation;
using MediatR;

namespace App.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest: IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}