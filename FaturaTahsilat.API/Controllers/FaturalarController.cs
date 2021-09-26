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
    public class FaturalarController : ControllerBase
    {
        private readonly IFaturaService _faturaService;
        private readonly IMapper _mapper;
        public FaturalarController(IFaturaService faturaService, IMapper mapper)
        {
            _faturaService = faturaService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faturalar = await _faturaService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<FaturaDto>>(faturalar));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var fatura = await _faturaService.GetByIdAsync(id);
            return Ok(_mapper.Map<FaturaDto>(fatura));
        }
        [HttpGet("{id}/tahsilatlar")]
        public async Task<IActionResult> GetWithTahsilatById(Guid id)
        {
            var fatura = await _faturaService.GetWithTahsilatById(id);
            return Ok(_mapper.Map<FaturaWithTahsilatDto>(fatura));
        }

        [HttpGet("{id}/tahsilatdetaylar")]
        public async Task<IActionResult> GetWithTahsilatDetayById(Guid id)
        {
            var fatura = await _faturaService.GetWithTahsilatDetayById(id);
            return Ok(_mapper.Map<FaturaDto>(fatura));
        }
        [HttpPost]
        public async Task<IActionResult> Save(FaturaDto faturaDto)
        {
            var newFatura = await _faturaService.AddAsync(_mapper.Map<Fatura>(faturaDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var fatura = _faturaService.GetByIdAsync(id).Result;
            _faturaService.Remove(fatura);
            return NoContent();
        }

    }
}


