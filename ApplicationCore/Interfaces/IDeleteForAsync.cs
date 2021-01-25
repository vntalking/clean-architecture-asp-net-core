using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IDeleteForAsync<TKey>
    {
        Task<OperationResult> DeleteAsync(TKey key);
    }
}
