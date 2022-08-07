using App.Application.DTOs.Common;

namespace App.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto: ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
    }
}