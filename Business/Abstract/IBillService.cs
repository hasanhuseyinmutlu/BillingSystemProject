using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillService
    {
        IDataResult<List<Bill>> GetAll();
        IResult Add(Bill bill);
        IResult Delete(Bill bill);
        IResult Update(Bill bill);

    }
}
