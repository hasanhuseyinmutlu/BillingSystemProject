using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator() 
        {
            RuleFor(x => x.ApartmentId).NotEmpty().NotNull();

            RuleFor(x => x.Amount).GreaterThan(30).WithMessage("30'dan yüksek tutar giriniz !");
            RuleFor(x => x.Amount).LessThan(50000).WithMessage("50 bin üzerinde tutar giremezsiniz !");

            RuleFor(x => x.BillDate).Must(ValidBillDate).WithMessage("Fatura tarihi geçerli bir tarih aralığında olmalıdır.");
           
            RuleFor(x => x.Type).NotEmpty().NotNull();
        }

        private bool ValidBillDate(DateTime time)
        {
            DateTime currentMonthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime nextMonthEnd = currentMonthStart.AddMonths(2).AddDays(-1);

            return (time >= currentMonthStart && time <= nextMonthEnd);
        }
    }
}
