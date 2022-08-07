using App.Application.DTOs;
using App.Application.DTOs.LeaveType;
using MediatR;

namespace App.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest: IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}