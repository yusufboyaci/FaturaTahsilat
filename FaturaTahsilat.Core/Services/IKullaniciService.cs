using FaturaTahsilat.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Services
{
    public interface IKullaniciService : IService<Kullanici>
    {
        Task<Kullanici> GetWithFaturaByIdAsync(Guid KullaniciId);
        Task<Kullanici> GetWithAboneByIdAsync(Guid KullaniciId);
        Task<Kullanici> GetWithTahsilatByIdAsync(Guid KullaniciId);
    }
}
