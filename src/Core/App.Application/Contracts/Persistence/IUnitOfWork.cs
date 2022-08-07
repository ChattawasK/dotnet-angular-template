namespace App.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        ILeaveTypeRepository LeaveTypeRepository{ get; }
        ILeaveRequestRepository LeaveRequestRepository{ get; }
        ILeaveAllocationRepository LeaveAllocationRepository{ get; }
        Task Save();
    }
}