using App.Application.DTOs.LeaveType;
using App.Application.Responses;
using MediatR;

namespace App.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}