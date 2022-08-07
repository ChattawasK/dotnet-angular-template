using FluentValidation;

namespace App.Application.DTOs.LeaveType.Validations
{
    public class UpdateLeaveTypeDtoValidator: AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}