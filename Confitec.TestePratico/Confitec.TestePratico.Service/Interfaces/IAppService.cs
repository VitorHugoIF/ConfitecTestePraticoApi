using Confitec.TestePratico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Service.Dto;

namespace Confitec.TestePratico.Service.Interfaces
{
    public interface IAppService<TEntity, TEntityDto> where TEntity : Entity where TEntityDto : EntityDto
    {
        Task<IEnumerable<TEntityDto>> Get();
        Task<TEntityDto> Get(int id, bool asNoTracking = false);
        Task<TEntityDto> Add(TEntityDto entity);
        Task<TEntityDto> Update(TEntityDto entity);
        Task Delete(int id);
    }
}
