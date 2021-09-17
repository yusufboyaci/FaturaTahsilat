using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Data.Repositories
{
    public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
    {
        private ApplicationDbContext _appContext { get => _context as ApplicationDbContext; }
        public KullaniciRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<Kullanici> GetWithAboneByIdAsync(Guid kullaniciId) => await _appContext.Kullanicilar.Include(x => x.Aboneler).SingleOrDefaultAsync(x => x.Id == kullaniciId);


        public async Task<Kullanici> GetWithByTahsilatIdAsync(Guid kullaniciId) => await _appContext.Kullanicilar.Include(x => x.Aboneler.ToList().AsQueryable().Include(x => x.Tahsilatlar)).SingleOrDefaultAsync(x => x.Id == kullaniciId);


        public async Task<Kullanici> GetWithFaturaByIdAsync(Guid kullaniciId) => await _appContext.Kullanicilar.Include(x => x.Aboneler.ToList().AsQueryable().Include(x => x.Faturalar)).SingleOrDefaultAsync(x => x.Id == kullaniciId);

    }
}
