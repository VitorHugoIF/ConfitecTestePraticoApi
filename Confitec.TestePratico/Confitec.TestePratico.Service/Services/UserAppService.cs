using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Interfaces.Service;
using Confitec.TestePratico.Service.Dto;
using Confitec.TestePratico.Service.Interfaces;

namespace Confitec.TestePratico.Service.Services
{
    public class UserAppService : AppService<User, UserDto>, IUserAppService
    {
        public UserAppService(IMapper mapper, IService<User> service) : base(mapper, service)
        {
        }
    }
}
