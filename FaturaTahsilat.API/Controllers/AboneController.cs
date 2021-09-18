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
    public class AboneController : ControllerBase
    {
        private readonly IService<Abone> _aboneService;
        private readonly IMapper _mapper;
        public AboneController(IService<Abone> aboneService, IMapper mapper)
        {
            _aboneService = aboneService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var aboneler = await _aboneService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<AboneDto>>(aboneler));
        }
        [HttpPost]
        public async Task<IActionResult> Save(AboneDto aboneDto)
        {
            //aboneDto.ID = new Guid();
            aboneDto.ID = Guid.NewGuid();
            var newAbone = await _aboneService.AddAsync(_mapper.Map<Abone>(aboneDto));
            return Created(string.Empty, _mapper.Map<AboneDto>(newAbone));
        }
        [HttpPut]
        public IActionResult Update(AboneDto aboneDto)
        {
            var abone = _aboneService.Update(_mapper.Map<Abone>(aboneDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var abone = _aboneService.GetByIdAsync(id).Result;
            _aboneService.Remove(abone);
            return NoContent();
        }
    }
}
