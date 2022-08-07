using App.Application.DTOs.Common;
using App.Application.DTOs.LeaveType;
using App.Application.Models.Identity;

namespace App.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto: BaseDto
    {
        public Employee Employee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Approved { get; set; }
    }
}