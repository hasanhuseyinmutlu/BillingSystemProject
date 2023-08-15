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
    public class UserCardManager : IUserCardService
    {
        IUserCardDal _userCardDal;
        public UserCardManager(IUserCardDal userCardDal)
        {
            _userCardDal = userCardDal;
        }
        [SecuredOperation("user")]
        [ValidationAspect(typeof(UserCardValidator))]
        public IResult Add(UserCard userCard)
        {
           _userCardDal.Add(userCard);
            return new SuccessResult(Messages.UserCardAdded);
        }
        [SecuredOperation("user")]
        public IResult Delete(UserCard userCard)
        {
            _userCardDal.Delete(userCard);
            return new SuccessResult(Messages.UserCardDeleted);
        }
        [SecuredOperation("user")]
        public IDataResult<List<UserCard>> GetAll()
        {
            return new SuccessDataResult<List<UserCard>>(_userCardDal.GetAll());
        }
        [SecuredOperation("user")]
        [ValidationAspect(typeof(UserCardValidator))]
        public IResult Update(UserCard userCard)
        {
            _userCardDal.Update(userCard);
            return new SuccessResult(Messages.UserCardUpdated);
        }
    }
}
