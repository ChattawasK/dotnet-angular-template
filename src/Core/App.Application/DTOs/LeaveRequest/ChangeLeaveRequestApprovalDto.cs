using App.Application.DTOs.Common;

namespace App.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto: BaseDto
    {
        public bool Approved { get; set; }
    }
}