using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserCardValidator : AbstractValidator<UserCard>
    {
        public UserCardValidator() 
        {
            
            RuleFor(c => c.CardNumber).NotEmpty();
            RuleFor(c => c.CardHolder).NotEmpty();
            RuleFor(c => c.Cvv).NotEmpty();
            RuleFor(c => c.ExpirationDate).NotEmpty();
            RuleFor(c => c.CardNumber).Must(x => x.Length == 16).WithMessage("Card uzunlugu dogru degil");
            RuleFor(c => c.CardNumber).Must(IsValidLuhn).WithMessage("Invalid Card Number");
        }
        private bool IsValidLuhn(string cardNumber)
        {
            int[] digits = cardNumber.Select(c => int.Parse(c.ToString())).ToArray();
            int checkDigit = 0;

            for (int i = digits.Length - 2; i >= 0; --i)
            {
                checkDigit += ((i & 1) is 0) switch
                {
                    true => digits[i] > 4 ? digits[i] * 2 - 9 : digits[i] * 2,
                    false => digits[i]
                };
            }

            return 10 - (checkDigit % 10) == digits.Last();
        }
    }
}
