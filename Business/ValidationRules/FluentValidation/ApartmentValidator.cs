using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ApartmentValidator : AbstractValidator<Apartment>
    {
        public ApartmentValidator() 
        {
            RuleFor(x => x.Type).NotEmpty().NotNull();
            RuleFor(x => x.ApartmentNumber).GreaterThanOrEqualTo(1).WithMessage("Lütfen geçerli apartman numarası giriniz ");
            RuleFor(x => x.Floor).GreaterThanOrEqualTo(0).WithMessage("hatalı kat girdiniz");
            RuleFor(x => x.Id).GreaterThanOrEqualTo(1).WithMessage("id minimum 1 olmalı");
        }

    }
}
