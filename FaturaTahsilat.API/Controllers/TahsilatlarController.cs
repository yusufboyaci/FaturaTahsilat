using AutoMapper;
using FaturaTahsilat.API.DTOs;
using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahsilatlarController : ControllerBase
    {
        private readonly IService<Tahsilat> _tahsilatService;
        private readonly IMapper _mapper;
        public TahsilatlarController(IService<Tahsilat> tahsilatService, IMapper mapper )
        {
            _tahsilatService = tahsilatService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tahsilatlar = await _tahsilatService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TahsilatDto>>(tahsilatlar));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var tahsilat = await _tahsilatService.GetByIdAsync(id);
            return Ok(_mapper.Map<TahsilatDto>(tahsilat));
        }
        [HttpPost]
        public async Task<IActionResult> Save(TahsilatDto tahsilatDto) 
        {
            var newTahsilat = await _tahsilatService.AddAsync(_mapper.Map<Tahsilat>(tahsilatDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var tahsilat = _tahsilatService.GetByIdAsync(id).Result;
            _tahsilatService.Remove(tahsilat);
            return NoContent();
        }
    }
}
