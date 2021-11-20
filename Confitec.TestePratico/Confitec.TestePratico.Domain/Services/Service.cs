using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Interfaces.Repository;
using Confitec.TestePratico.Domain.Interfaces.Service;

namespace Confitec.TestePratico.Domain.Services
{
    public class Service<T> : IService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _repository.Get();
        }

        public async Task<T> Get(int id, bool isAsNoTracking = false)
        {
            return await _repository.Get(id, isAsNoTracking);
        }

        public async Task<T> Add(T entity)
        {
            return await _repository.Add(entity);
        }

        public async Task<T> Update(T entity)
        {
            return await _repository.Update(entity);
        }

        public async Task Delete(T entity)
        {
            await _repository.Delete(entity);
        }
    }
}
