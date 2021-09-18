using FaturaTahsilat.UI.ApiService;
using FaturaTahsilat.UI.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.UI.Controllers
{
    public class AboneController : Controller
    {
        private readonly AboneApiService _aboneApiService;
        public AboneController(AboneApiService aboneApiService)
        {
            _aboneApiService = aboneApiService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _aboneApiService.GetAllAsync());
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(AboneDto aboneDto)
        {
            await _aboneApiService.AddAsync(aboneDto);
            return RedirectToAction("Index");
        }
    }
}
