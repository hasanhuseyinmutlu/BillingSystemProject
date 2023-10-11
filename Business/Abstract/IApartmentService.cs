using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApartmentService
    {
        IDataResult<List<AparmentDuesDetailDto>> GetApartmentDuesDetail();
        IDataResult<List<AparmentDuesDetailDto>> GetApartmentDuesById(int id);
        IDataResult<List<ApartmentBillDeatailDto>> GetAparmentBillDetail();
        IDataResult<List<ApartmentBillDeatailDto>> GetApartmentBillById(int id);
        IDataResult<List<ApartmentDetailDto>> GetCustomerAparmentDetail();
        IDataResult<List<Apartment>> GetAll();
        IDataResult<Apartment> GetById(int apartmentId);
        IResult Add(Apartment apartment);
        IResult Update(Apartment apartment);
        IResult Delete(Apartment apartment);
        

    }
}
