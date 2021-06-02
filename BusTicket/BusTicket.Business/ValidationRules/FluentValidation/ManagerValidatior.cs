using BusTicket.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.ValidationRules.FluentValidation
{
    public class ManagerValidatior : AbstractValidator<Manager>
    {
        public ManagerValidatior()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
        }
    }
}