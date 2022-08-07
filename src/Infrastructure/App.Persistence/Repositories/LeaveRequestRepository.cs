using App.Application.Contracts.Persistence;
using App.Domain;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Repositories {
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository {
        private readonly AppDbContext _dbContext;
        public LeaveRequestRepository (AppDbContext dbContext) : base (dbContext) {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus (LeaveRequest leaveRequest, bool? ApprovalStatus) {
            leaveRequest.Approved = ApprovalStatus;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails () {
            var leaveRequests = await _dbContext.LeaveRequests
                .Include(x => x.LeaveType)
                .ToListAsync();
            return leaveRequests;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails (string userId) {
            var leaveRequests = await _dbContext.LeaveRequests
                .Where(q=> q.RequestingEmployeeId == userId)
                .Include(q => q.LeaveType)
                .ToListAsync();
            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails (int id) {
            var leaveRequests = await _dbContext.LeaveRequests
                .Include(x => x.LeaveType)
                .FirstOrDefaultAsync(x => x.Id == id);
            return leaveRequests;
        }
    }
}