using DentisBooking.Data.Enum;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email is required!").EmailAddress();
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required!");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Password do not match").NotNull().NotEmpty().WithMessage("Confirm password is required!").MaximumLength(15);
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty().WithMessage("Phone number is required!").MaximumLength(15);
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("First name is required!");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("First name is required!");
            RuleFor(x => x.DOB).NotNull().NotEmpty().WithMessage("Date of birth is required!").GreaterThan(DateTime.MinValue).WithMessage("Date of birth must greater than min value!");
            RuleFor(x => x.Gender).IsInEnum<RegisterRequest,Gender>().WithMessage("Gender is required!").IsInEnum().WithMessage("Gender must be MALE or FEMALE!");

        }
    }
}