using Application.Commands.BloodGroups;
using FluentValidation;

namespace Application.Validators.BloodGroups
{
    public class CreateBloodGroupCommandValidator : AbstractValidator<CreateBloodGroupCommand>
    {
        public CreateBloodGroupCommandValidator()
        {
            RuleFor(v => v.Title).NotNull();
            RuleFor(v => v.Description).NotNull();
        }
    }
}
