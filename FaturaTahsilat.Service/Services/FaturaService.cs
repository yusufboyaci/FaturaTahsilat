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
   public class FaturaService:Service<Fatura>,IFaturaService
    {
        public FaturaService(IUnitOfWork unitOfWork, IRepository<Fatura> repository) : base(unitOfWork, repository)
        {

        }

        public Task<Fatura> GetWithTahsilatById(Guid faturaId)
        {
            throw new NotImplementedException();
        }

        public Task<Fatura> GetWithTahsilatDetayById(Guid faturaId)
        {
            throw new NotImplementedException();
        }
    }
}
