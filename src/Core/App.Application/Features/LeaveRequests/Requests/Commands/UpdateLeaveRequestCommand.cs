using App.Application.DTOs.LeaveRequest;
using MediatR;

namespace App.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand: IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; }
    }
}