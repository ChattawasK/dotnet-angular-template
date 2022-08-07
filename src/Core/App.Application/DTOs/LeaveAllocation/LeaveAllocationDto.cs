using App.Application.DTOs.Common;
using App.Application.DTOs.LeaveType;
using App.Application.Models.Identity;

namespace App.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
         public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}