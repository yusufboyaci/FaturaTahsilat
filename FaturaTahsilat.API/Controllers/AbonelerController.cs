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
    public class AbonelerController : ControllerBase
    {
        private readonly IService<Abone> _aboneService;
        private readonly IMapper _mapper;
        public AbonelerController(IService<Abone> aboneService, IMapper mapper)
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
            var newAbone = await _aboneService.AddAsync(_mapper.Map<Abone>(aboneDto));
            return Created(string.Empty, _mapper.Map<AboneDto>(newAbone));
        }
    }
}
