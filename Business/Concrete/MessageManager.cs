using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public IResult Add(Message message)
        {
            
            _messageDal.Add(message);
            return new SuccessResult(Messages.MessageAdded);
        }

        public IResult Delete(Message message)
        {
            _messageDal.Delete(message);
            return new SuccessResult(Messages.MessageDeleted);
        }

        public IDataResult<List<Message>> GetAll()
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll());
        }

        public IResult Update(Message message)
        {
            _messageDal.Update(message);
            return new SuccessResult(Messages.MessageUpdate);
        }
    }
}
