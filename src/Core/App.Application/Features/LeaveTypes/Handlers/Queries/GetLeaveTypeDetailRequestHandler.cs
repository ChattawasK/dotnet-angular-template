using App.Application.Contracts.Persistence;
using App.Application.DTOs;
using App.Application.DTOs.LeaveType;
using App.Application.Features.LeaveTypes.Requests.Queries;
using AutoMapper;
using MediatR;

namespace App.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;


        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var LeaveTypes = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(LeaveTypes);
        }
    }
}