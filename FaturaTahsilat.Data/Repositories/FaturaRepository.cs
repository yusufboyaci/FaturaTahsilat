using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.Data.Repositories
{
    public class FaturaRepository : Repository<Fatura>, IFaturaRepository
    {
        private ApplicationDbContext _appContext { get => _context as ApplicationDbContext; }
        public FaturaRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<Fatura> GetWithTahsilatById(Guid faturaId) => await _appContext.Faturalar.Include(x => x.Abone.Tahsilatlar).SingleOrDefaultAsync(x => x.Id == faturaId);


        public async Task<Fatura> GetWithTahsilatDetayById(Guid faturaId) => await _appContext.Faturalar.Include(x => x.TahsilatDetaylar).SingleOrDefaultAsync(x => x.Id == faturaId);

    }
}
