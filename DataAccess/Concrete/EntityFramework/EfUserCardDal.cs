using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserCardDal : EfEntityRepositoryBase<UserCard, BMSContext>, IUserCardDal
    {
        public List<CustomerCardDetailDto> GetCustomerCard(int id)
        {
            using (BMSContext context = new BMSContext())
            {
                var result = from user in context.Users
                             join userCard in context.UserCards
                             on user.Id equals userCard.Id
                             where userCard.UserId == id

                             select new CustomerCardDetailDto()
                             {
                                 UserId = userCard.UserId,
                                 CardName = userCard.CardHolder,
                                 CardNumber = userCard.CardNumber,
                                 ExpirationDate = userCard.ExpirationDate,
                                 Cvv = userCard.Cvv
                             };
                return result.ToList();
            }
        }
    }
}
