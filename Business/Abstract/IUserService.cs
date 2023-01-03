﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        void Add(User user);
        IResult Update(User entity);
        IResult Delete(User entity);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);  

    }
}
