using FaturaTahsilat.Core.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Repositories
{
    public interface IFaturaRepository : IRepository<Fatura>
    {
        Task<Fatura> GetWithTahsilatById(Guid faturaId);
        Task<Fatura> GetWithTahsilatDetayById(Guid faturaId);
    }
}
