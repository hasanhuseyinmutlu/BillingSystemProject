using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IApartmentDal : IEntityRepository<Apartment>
    {
        List<ApartmentDetailDto> GetCustomerAparmentDetail();
        List<ApartmentBillDeatailDto> GetApartmentBillDeatail();
        List<AparmentDuesDetailDto> GetApartmentDuesDeatail();

        List<ApartmentBillDeatailDto> GetApartmentBillById(int id);
        List<AparmentDuesDetailDto> GetApartmentDuesById(int id);
    }
}
