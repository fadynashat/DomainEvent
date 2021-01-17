using FluentValidation;
using Salary.API.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.API.Application.Validations
{
    public class CreateSalaryCommandValidator : AbstractValidator<CreateSalaryCommand>
    {
        public CreateSalaryCommandValidator()
        {
            RuleFor(command => command.Salary).LessThan(10000).NotEmpty().WithMessage("The Salary Must be less than 10000");
        }
    }
}
