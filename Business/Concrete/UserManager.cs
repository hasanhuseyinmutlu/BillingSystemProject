using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
           _userDal.Add(user);
            return new SuccessResult();
        }

        public User GetbyMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            return result;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            return result;
        }
    }
}
