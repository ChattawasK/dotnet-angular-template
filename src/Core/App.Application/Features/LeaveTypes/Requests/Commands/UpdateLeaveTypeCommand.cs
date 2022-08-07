using App.Application.DTOs.LeaveType;
using MediatR;

namespace App.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand: IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}