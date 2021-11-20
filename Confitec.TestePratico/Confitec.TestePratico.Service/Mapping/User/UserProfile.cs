using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Confitec.TestePratico.Service.Dto;

namespace Confitec.TestePratico.Service.Mapping.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.Entities.User, UserDto>().ReverseMap();
        }
    }
}
