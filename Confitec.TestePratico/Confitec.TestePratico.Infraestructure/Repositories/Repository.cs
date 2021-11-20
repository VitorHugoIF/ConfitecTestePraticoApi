using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Interfaces.Repository;
using Confitec.TestePratico.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Confitec.TestePratico.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T: Entity
    {
        private readonly ConfitecContext _dbContext;

        public Repository(ConfitecContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> Get(int id, bool isAsNoTracking = false)
        {
            if (isAsNoTracking)
            {
                return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            }

            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
