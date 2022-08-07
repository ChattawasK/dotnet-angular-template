using App.Application.DTOs.LeaveRequest;
using App.Application.Responses;
using MediatR;

namespace App.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand: IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}