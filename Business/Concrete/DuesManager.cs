using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
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
    public class DuesManager : IDuesService
    {
        IDuesDal _duesDal;

        public DuesManager(IDuesDal duesDal)
        {
            _duesDal = duesDal;
        }
        //   [SecuredOperation("admin")]
        [ValidationAspect(typeof(DuesValidator))]
        public IResult Add(Dues dues)
        {
            _duesDal.Add(dues);
            return new SuccessResult(Messages.DuesAdded);
        }
        [SecuredOperation("admin")]
        public IResult Delete(Dues dues)
        {
            _duesDal.Delete(dues);
            return new SuccessResult(Messages.DuesDeleted);
        }
        //   [SecuredOperation("admin")]
        public IDataResult<List<Dues>> GetAll()
        {
           return new SuccessDataResult<List<Dues>>(_duesDal.GetAll());
        }
        [SecuredOperation("admin")]

        [ValidationAspect(typeof(DuesValidator))]
        public IResult Update(Dues dues)
        {
            _duesDal.Update(dues);
            return new SuccessResult(Messages.DuesUpdated);
        }
    }
}
