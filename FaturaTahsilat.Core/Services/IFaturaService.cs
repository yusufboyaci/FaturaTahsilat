using FaturaTahsilat.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Services
{
    public interface IFaturaService : IService<Fatura>
    {
        Task<Fatura> GetWithTahsilatById(Guid faturaId);
        Task<Fatura> GetWithTahsilatDetayById(Guid faturaId);
    }
}
