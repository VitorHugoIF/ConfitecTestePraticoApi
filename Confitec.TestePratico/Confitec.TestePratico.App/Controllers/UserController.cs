using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Confitec.TestePratico.Service.Dto;
using Confitec.TestePratico.Service.Interfaces;

namespace Confitec.TestePratico.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userAppService.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _userAppService.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto userDto)
        {
            var userDtoResult = await _userAppService.Add(userDto);
            return CreatedAtAction(nameof(Get), new { id = userDtoResult.Id }, userDtoResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserDto userDto)
        {
            return Ok(await _userAppService.Update(id, userDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userAppService.Delete(id);
            return Ok();
        }
    }
}
