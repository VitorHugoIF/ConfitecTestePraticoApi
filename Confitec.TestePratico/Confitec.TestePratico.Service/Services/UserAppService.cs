using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Interfaces.Service;
using Confitec.TestePratico.Service.Dto;
using Confitec.TestePratico.Service.Exceptions;
using Confitec.TestePratico.Service.Interfaces;

namespace Confitec.TestePratico.Service.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IService<User> _service;

        public UserAppService(IMapper mapper, IService<User> service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IEnumerable<UserDto>> Get()
        {
            return _mapper.Map<IEnumerable<UserDto>>(await _service.Get());
        }

        public async Task<UserDto> Get(int id, bool isAsNoTracking = false)
        {
            return _mapper.Map<UserDto>(await _service.Get(id, isAsNoTracking));
        }

        public async Task<UserDto> Add(UserDto entityDto)
        {
            var entity = await _service.Add(_mapper.Map<User>(entityDto));
            return _mapper.Map<UserDto>(entity);
        }

        public async Task<UserDto> Update(int id, UserDto entityDto)
        {
            var entityToUpdate = await _service.Get(entityDto.Id, true);
            if (id != entityDto.Id || entityToUpdate == null)
            {
                throw new NotFoundException("Usuário não encontrado");
            }

            var entity = await _service.Update(_mapper.Map<User>(entityDto));
            return _mapper.Map<UserDto>(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _service.Get(id);
            if (entity == null)
            {
                throw new NotFoundException("Usuário não encontrado");
            }

            await _service.Delete(_mapper.Map<User>(entity));
        }
    }
}
