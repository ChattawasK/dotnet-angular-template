using App.Application.DTOs.Common;

namespace App.Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}