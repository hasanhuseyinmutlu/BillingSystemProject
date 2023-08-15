using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserPaymentDto : IDto
    {
        public UserCard UserCreditCard { get; set; }
        public Payment Payment { get; set; }
    }
}
