using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x=>x.FirstName).NotEmpty().NotNull();
            RuleFor(x => x.LastName).NotEmpty().NotNull();

            RuleFor(x =>x.IdentityNumber).Equal(16).WithMessage("hatalı kimlik numarası");
            RuleFor(x =>x.IdentityNumber).NotNull().NotEmpty().WithMessage("kimlik boş bırakılamaz");

            RuleFor(x => x.PlateNumber).Must(ValidPlateNumber).WithMessage("Geçerli bir plaka numarası giriniz.");

            RuleFor(x => x.TelephoneNumber).Must(ValidTelephoneNumber).WithMessage("Geçerli bir telefon giriniz : 05xxxxxxxxx");

        }

        private bool ValidTelephoneNumber(string number)
        {
            Regex regex = new Regex(@"^(05(\d{9}))$");
            return regex.IsMatch(number);
        }

        private bool ValidPlateNumber(string plate)
        {
            Regex regex = new Regex("(0[1-9]|[1-7][0-9]|8[01])(([A-Z])(\\d{4,5})|([A-Z]{2})(\\d{3,4})|([A-Z]{3})(\\d{2}))");
            return regex.IsMatch(plate);
        }
    }
}
