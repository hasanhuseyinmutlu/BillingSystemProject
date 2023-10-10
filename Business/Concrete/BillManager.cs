using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillManager : IBillService
    {
        IBillDal _billDal;

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }
        //   [SecuredOperation("admin")]
        [ValidationAspect(typeof(BillValidator))]
       // [CacheRemoveAspect("IBillService.Get")]
        public IResult Add(Bill bill)
        {
            _billDal.Add(bill);
            return new SuccessResult(Messages.BillAdded);
        }
       // [SecuredOperation("admin")]
       // [CacheRemoveAspect("IBillService.Get")]
        public IResult Delete(Bill bill)
        {
            _billDal.Delete(bill);
            return new SuccessResult(Messages.BillDeleted);
        }
        //[SecuredOperation("admin")]
      // [CacheAspect(duration: 10)]
        public IDataResult<List<Bill>> GetAll()
        {
            return new SuccessDataResult<List<Bill>>(_billDal.GetAll());
        }
        //  [SecuredOperation("admin")]
        [ValidationAspect(typeof(BillValidator))]
       // [CacheRemoveAspect("IBillService.Get")]
        public IResult Update(Bill bill)
        {
            _billDal.Update(bill);
            return new SuccessResult(Messages.BillUpdated);
        }
    }
}
