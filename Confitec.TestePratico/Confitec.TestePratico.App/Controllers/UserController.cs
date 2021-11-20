using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Service.Dto;
using Confitec.TestePratico.Service.Interfaces;

namespace Confitec.TestePratico.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAppService<User, UserDto> _appService;

        public UserController(IAppService<User, UserDto> appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appService.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _appService.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto userDto)
        {
            var userDtoResult = await _appService.Add(userDto);
            return CreatedAtAction(nameof(Get), new { id = userDtoResult.Id }, userDtoResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserDto userDto)
        {
            if (id != userDto?.Id)
            {
                return BadRequest("Não foi possivel Atualizar");
            }

            return Ok(await _appService.Update(userDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _appService.Delete(id);
            return Ok();
        }
    }
}
