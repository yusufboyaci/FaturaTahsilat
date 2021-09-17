using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Service.Services
{
    public class KullaniciService : Service<Kullanici>, IKullaniciRepository
    {
        public KullaniciService(IUnitOfWork unitOfWork, IRepository<Kullanici> repository) : base(unitOfWork, repository)
        {

        }

        public Task<Kullanici> GetWithAboneByIdAsync(Guid kullaniciId)
        {
            throw new NotImplementedException();
        }

        public Task<Kullanici> GetWithByTahsilatIdAsync(Guid kullaniciId)
        {
            throw new NotImplementedException();
        }

        public Task<Kullanici> GetWithFaturaByIdAsync(Guid kullaniciId)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Kullanici>.AddAsync(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Kullanici>.AddRangeAsync(IEnumerable<Kullanici> entities)
        {
            throw new NotImplementedException();
        }
    }
}
