using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DuesValidator : AbstractValidator<Dues>
    {
        public DuesValidator() 
        {
            RuleFor(x => x.ApartmentId).NotEmpty().NotNull();

            RuleFor(x => x.DuesDate).NotEmpty().NotNull();

            RuleFor(x => x.Amount).NotEmpty().NotNull();
            RuleFor(x => x.Amount).GreaterThan(0);
        }
    }
}
