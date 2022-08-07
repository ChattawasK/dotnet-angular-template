using App.Application.DTOs;
using App.Application.DTOs.LeaveAllocation;
using MediatR;

namespace App.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest: IRequest<List<LeaveAllocationDto>>
    {
        public bool IsLoggedInUser { get; set; }
    }
}