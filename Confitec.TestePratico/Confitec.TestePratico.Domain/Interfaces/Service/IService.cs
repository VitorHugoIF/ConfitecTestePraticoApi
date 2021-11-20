using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;

namespace Confitec.TestePratico.Domain.Interfaces.Service
{
    public interface IService<T> where T : Entity
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id, bool isAsNoTracking = false);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
