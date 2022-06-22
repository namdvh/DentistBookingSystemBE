using System;
using DentisBooking.Data.Enum;
using FluentValidation;

namespace DentistBooking.ViewModels.System.Dentists
{
    public class AddDentistRequestValidator: AbstractValidator<AddDentistRequest>
    {
        public AddDentistRequestValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email is required!").EmailAddress();
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required!");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Password do not match").NotNull().NotEmpty().WithMessage("Confirm password is required!").MaximumLength(15);
            RuleFor(x => x.Phone).NotNull().NotEmpty().WithMessage("Phone number is required!").MaximumLength(15);
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("First name is required!");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("First name is required!");
            RuleFor(x => x.Gender).IsInEnum<AddDentistRequest,Gender>().WithMessage("Gender is required!").IsInEnum().WithMessage("Gender must be MALE or FEMALE!");
            RuleFor(x => x.Status).IsInEnum<AddDentistRequest,Status>().WithMessage("Status is required!").IsInEnum().WithMessage("Status must be ACTIVE or INACTIVE!");
            RuleFor(x => x.Position).IsInEnum<AddDentistRequest,Position>().WithMessage("Position is required!").IsInEnum().WithMessage("Position must be HEAD or DENTIST or ASSISTANT!");
        }
    }
}