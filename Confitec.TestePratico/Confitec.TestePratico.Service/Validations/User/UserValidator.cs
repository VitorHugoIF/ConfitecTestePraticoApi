using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Enums;
using Confitec.TestePratico.Service.Dto;
using FluentValidation;

namespace Confitec.TestePratico.Service.Validations.User
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Nome).NotEmpty().MaximumLength(30);
            RuleFor(user => user.Sobrenome).NotEmpty().MaximumLength(30);
            RuleFor(user => user.Email).NotEmpty().EmailAddress().MaximumLength(100);
            RuleFor(user => user.DataNascimento).NotNull().NotEmpty().LessThanOrEqualTo(DateTime.Now.Date);
            RuleFor(user => user.Escolaridade).NotNull().NotEmpty().Must(IsValidSchoolingEnum);
        }

        private bool IsValidSchoolingEnum(int value)
        {
            return Enum.IsDefined(typeof(SchoolingEnum), value);
        }
    }
}
