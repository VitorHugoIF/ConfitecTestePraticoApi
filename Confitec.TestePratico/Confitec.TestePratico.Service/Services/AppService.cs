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
    public class AppService<TEntity, TEntityDto> : IAppService<TEntity, TEntityDto> where TEntity : Entity where TEntityDto : EntityDto
    {
        private readonly IMapper _mapper;
        private readonly IService<TEntity> _service;

        public AppService(IMapper mapper, IService<TEntity> service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IEnumerable<TEntityDto>> Get()
        {
            return  _mapper.Map<IEnumerable<TEntityDto>>(await _service.Get());
        }

        public async Task<TEntityDto> Get(int id, bool asNoTracking = false)
        {
            return _mapper.Map<TEntityDto>(await _service.Get(id, asNoTracking));
        }

        public async Task<TEntityDto> Add(TEntityDto entityDto)
        {
            var entity = await _service.Add(_mapper.Map<TEntity>(entityDto));
            return _mapper.Map<TEntityDto>(entity);
        }

        public async Task<TEntityDto> Update(TEntityDto entityDto)
        {
            var entityToUpdate = await _service.Get(entityDto.Id, true);
            if (entityToUpdate == null)
            {
                throw new NotFoundException("");
            }

            var entity = await _service.Update(_mapper.Map<TEntity>(entityDto));
            return _mapper.Map<TEntityDto>(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _service.Get(id);
            if (entity == null)
            {
                throw new NotFoundException("");
            }

            await _service.Delete(_mapper.Map<TEntity>(entity));
        }
    }
}
