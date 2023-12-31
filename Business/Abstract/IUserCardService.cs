﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserCardService
    {
        IResult Add(UserCard userCard);

        IResult Update(UserCard userCard);

        IResult Delete(UserCard userCard);

        IDataResult<List<UserCard>> GetAll();  

        IDataResult<List<CustomerCardDetailDto>> GetCustomerCard(int id);


    }
}
