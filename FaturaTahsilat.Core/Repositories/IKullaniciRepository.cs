using FaturaTahsilat.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Repositories
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        Task<Kullanici> GetWithFaturaByIdAsync(Guid kullaniciId);
        Task<Kullanici> GetWithAboneByIdAsync(Guid kullaniciId);
        Task<Kullanici> GetWithByTahsilatIdAsync(Guid kullaniciId);
    }
}
