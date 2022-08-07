using App.Application.DTOs.LeaveRequest;
using MediatR;

namespace App.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest: IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}