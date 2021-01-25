﻿using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface ITermsService :
        ICreateForAsync<InputTerm>,
        IUpdateForAsync<InputTerm, int>,
        IDeleteForAsync<int>,
        IGetAllFor<Term>,
        IFindForAsync<Term, int>
    {

    }
}
