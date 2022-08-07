using App.Application.DTOs.LeaveType;
using MediatR;

namespace App.Application.Features.LeaveTypes.Requests.Commands
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}