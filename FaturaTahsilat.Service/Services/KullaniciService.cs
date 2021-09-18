using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Core.Services;
using FaturaTahsilat.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Service.Services
{
    public class KullaniciService : Service<Kullanici>, IKullaniciService
    {
        public KullaniciService(IUnitOfWork unitOfWork, IRepository<Kullanici> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<Kullanici> GetWithAboneByIdAsync(Guid kullaniciId) => await _unitOfWork.Kullanici.GetWithAboneByIdAsync(kullaniciId);

        public async Task<Kullanici> GetWithTahsilatByIdAsync(Guid kullaniciId) => await _unitOfWork.Kullanici.GetWithByTahsilatIdAsync(kullaniciId);


        public async Task<Kullanici> GetWithFaturaByIdAsync(Guid kullaniciId) => await _unitOfWork.Kullanici.GetWithFaturaByIdAsync(kullaniciId);       
       
    }
}
