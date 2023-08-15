using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        IDataResult<List<Message>> GetAll();
        IResult Add(Message message);
        IResult Delete(Message message);
        IResult Update(Message message);
    }
}
