using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApartmentManager : IApartmentService
    {
        IApartmentDal _apartmentDal;

        public ApartmentManager(IApartmentDal apartmentDal)
        {
            _apartmentDal = apartmentDal;
        }

        [ValidationAspect(typeof(ApartmentValidator))]
       // [SecuredOperation("aparment.add, admin")]
        public IResult Add(Apartment apartment)
        {
            _apartmentDal.Add(apartment);

            return new SuccessResult(Messages.ApartmentAdded);
        }
       // [SecuredOperation("admin")]
        public IResult Delete(Apartment apartment)
        {
            _apartmentDal.Delete(apartment);
            return new SuccessResult(Messages.AparmentDeleted);
        }
       // [SecuredOperation("admin")]
        public IDataResult<List<Apartment>> GetAll()
        {
           return new SuccessDataResult<List<Apartment>>(_apartmentDal.GetAll());
        }
       // [SecuredOperation("admin")]
        public IDataResult<List<ApartmentBillDeatailDto>> GetAparmentBillDetail()
        {
            return new SuccessDataResult<List<ApartmentBillDeatailDto>>(_apartmentDal.GetApartmentBillDeatail().ToList());
        }

        public IDataResult<List<ApartmentBillDeatailDto>> GetApartmentBillById(int id)
        {
            // business logic 
            var customerInfo = _apartmentDal.GetApartmentBillById(id);
            if (customerInfo == null || customerInfo.Count == 0)
            {
                return new ErrorDataResult<List<ApartmentBillDeatailDto>>(Messages.BillDetailEmpty);
            }
            return new SuccessDataResult<List<ApartmentBillDeatailDto>>(_apartmentDal.GetApartmentBillById(id));
        }

        public IDataResult<List<AparmentDuesDetailDto>> GetApartmentDuesDetail()
        {
            return new SuccessDataResult<List<AparmentDuesDetailDto>>(_apartmentDal.GetApartmentDuesDeatail().ToList());
        }
      //  [SecuredOperation("admin")]
        public IDataResult<Apartment> GetById(int apartmentId)
        {
            return new SuccessDataResult<Apartment>(_apartmentDal.Get(a => a.Id == apartmentId));
        }
        
        public IDataResult<List<ApartmentDetailDto>> GetCustomerAparmentDetail()
        {
            return new SuccessDataResult<List<ApartmentDetailDto>>(_apartmentDal.GetCustomerAparmentDetail().ToList());
        }
      //  [SecuredOperation("admin")]
        [ValidationAspect(typeof(ApartmentValidator))]
        public IResult Update(Apartment apartment)
        {
            _apartmentDal.Update(apartment);
            return new SuccessResult(Messages.ApartmentUpdated);
        }
    }
}
