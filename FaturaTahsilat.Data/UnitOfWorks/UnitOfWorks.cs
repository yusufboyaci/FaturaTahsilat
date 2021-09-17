using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Core.UnitOfWorks;
using FaturaTahsilat.Data.Context;
using FaturaTahsilat.Data.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.Data.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        
        private FaturaRepository _faturaRepository;
       
        private KullaniciRepository _kullaniciRepository;
        
        public IFaturaRepository Fatura => _faturaRepository = _faturaRepository ?? new FaturaRepository(_context);
        public IKullaniciRepository Kullanici => _kullaniciRepository = _kullaniciRepository ?? new KullaniciRepository(_context);

       
        public UnitOfWorks(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
