using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICreateForAsync<T> where T : class
    {
        Task<OperationResult> CreateAsync(T entityToCreate);
    }
}
