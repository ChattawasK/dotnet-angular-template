using App.Application.Contracts.Persistence;
using App.Application.DTOs.LeaveType.Validations;
using App.Application.Exceptions;
using App.Application.Features.LeaveTypes.Requests.Commands;
using App.Domain;
using AutoMapper;
using MediatR;

namespace App.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveType = await _unitOfWork.LeaveTypeRepository.Get(request.LeaveTypeDto.Id);

            if (leaveType is null)
                throw new NotFoundException(nameof(leaveType), request.LeaveTypeDto.Id);

            _mapper.Map(request.LeaveTypeDto, leaveType);

            await _unitOfWork.LeaveTypeRepository.Update(leaveType);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}