using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Service.Dto;

namespace Confitec.TestePratico.Service.Interfaces
{
    public interface IUserAppService : IAppService<User, UserDto>
    {
    }
}
