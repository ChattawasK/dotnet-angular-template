using App.Application.Contracts.Persistence;
using App.Domain;

namespace App.Persistence.Repositories {
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository {
        private readonly AppDbContext _dbContext;
        public LeaveTypeRepository (AppDbContext dbContext) : base (dbContext) {
            _dbContext = dbContext;
        }
    }
}