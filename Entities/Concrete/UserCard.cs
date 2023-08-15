using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvv { get; set; }

    }
}
