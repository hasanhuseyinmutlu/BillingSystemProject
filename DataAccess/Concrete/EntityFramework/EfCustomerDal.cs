using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BMSContext>, ICustomerDal
    {
        public List<CustomerForInfoDto> GetCustomerInfo(Expression<Func<Customer, bool>> filter = null)
        {
            using (var context = new BMSContext()) 
            {
                var result = from u in filter == null ? context.Customers : context.Customers.Where(filter)
                             select new CustomerForInfoDto
                             {
                                 Id = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 MailAddress = u.MailAddress,
                                 TellNo = u.TelephoneNumber
                                 
                             };
                return result.ToList();
            }
        }
    }
}
