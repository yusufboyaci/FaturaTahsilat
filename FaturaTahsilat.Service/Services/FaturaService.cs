using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Core.Services;
using FaturaTahsilat.Core.UnitOfWorks;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.Service.Services
{
    public class FaturaService : Service<Fatura>, IFaturaService
    {
        public FaturaService(IUnitOfWork unitOfWork, IRepository<Fatura> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<Fatura> GetWithTahsilatById(Guid faturaId) => await _unitOfWork.Fatura.GetWithTahsilatById(faturaId);


        public async Task<Fatura> GetWithTahsilatDetayById(Guid faturaId) => await _unitOfWork.Fatura.GetWithTahsilatDetayById(faturaId);

    }
}
