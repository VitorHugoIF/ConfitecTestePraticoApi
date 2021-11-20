using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Service.Dto;

namespace Confitec.TestePratico.Service.Interfaces
{
    public interface IUserAppService
    {
        Task<IEnumerable<UserDto>> Get();
        Task<UserDto> Get(int id, bool isAsNoTracking = false);
        Task<UserDto> Add(UserDto entity);
        Task<UserDto> Update(int id, UserDto entity);
        Task Delete(int id);
    }
}
