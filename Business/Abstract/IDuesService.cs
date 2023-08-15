using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDuesService
    {
        IDataResult<List<Dues>> GetAll();

        IResult Add(Dues dues);
        IResult Delete(Dues dues);
        IResult Update(Dues dues);

    }
}
