using Castle.Core.Resource;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfAparmentDal : EfEntityRepositoryBase<Apartment, BMSContext>, IApartmentDal
    {
        public List<ApartmentDetailDto> GetCustomerAparmentDetail()
        {
            using(BMSContext context = new BMSContext())
            {
                var result = from customer in context.Customers
                             join apartment in context.Apartments 
                             on customer.Id equals apartment.CustomerId
                             select new ApartmentDetailDto
                             {
                                 CustomerId = customer.Id,                                
                                 Block = apartment.Block,
                                 Type = apartment.Type,
                                 Floor = apartment.Floor,
                                 ApartmentNumber = apartment.ApartmentNumber,
                                 OwnerOrTenant = apartment.OwnerOrTenant,
                                 Mail = customer.MailAddress
                             };
                return result.ToList();
               
            }
            //var apartmentDetails = (from customer in customers
            //                        join apartment in apartments on customer.Id equals apartment.Id
            //                        select new ApartmentDetailDto
            //                        {
            //                            CustomerId = customer.Id,
            //                            AparmentId = apartment.Id,
            //                            Blok = apartment.Block,
            //                            Type = apartment.Type,
            //                            Floor = apartment.Floor,
            //                            ApartmentNumber = apartment.ApartmentNumber,
            //                            OwnerOrTenant = apartment.OwnerOrTenant
            //                        }).ToList();
        }


        public List<ApartmentBillDeatailDto> GetApartmentBillDeatail()
        {
            using (BMSContext context = new BMSContext())
            {
                var result = from bill in context.Bills
                             join apartment in context.Apartments
                             on bill.ApartmentId equals apartment.Id
                             select new ApartmentBillDeatailDto
                             {
                                 BillAmount = bill.Amount,
                                 BillType = bill.Type,
                                 BillDate = bill.BillDate.ToString("dd.MM.yyyy"),
                                 ApartmentBlock = apartment.Block,
                                 ApartmentNumber = apartment.ApartmentNumber 
                                 
                             };
                return result.ToList();
            }
        }
        
        public List<AparmentDuesDetailDto> GetApartmentDuesDeatail()
        {
            using (BMSContext context = new BMSContext())
            {
                var reult = from due in context.Dues
                            join apartment in context.Apartments
                            on due.ApartmentId equals apartment.Id
                            select new AparmentDuesDetailDto
                            {
                                DuesAmount = due.Amount,
                                DuesDate = due.DuesDate.ToString("dd.MM.yyyy"),
                                ApartmentNumber = apartment.ApartmentNumber,
                                ApartmentBlock = apartment.Block,
                            };
                return reult.ToList();
            }
        }

        public List<ApartmentBillDeatailDto> GetApartmentBillById(int id)
        {
            using (BMSContext context = new BMSContext())
            {
                var result = from bill in context.Bills
                             join apartment in context.Apartments
                             on bill.ApartmentId equals apartment.Id
                             where apartment.CustomerId == id
                             select new ApartmentBillDeatailDto
                             {
                                 BillAmount = bill.Amount,
                                 BillType = bill.Type,
                                 BillDate = bill.BillDate.ToString("dd.MM.yyyy"),
                                 ApartmentBlock = apartment.Block,
                                 ApartmentNumber = apartment.ApartmentNumber
                             };

                return result.ToList();

            }

        }
    }
}
