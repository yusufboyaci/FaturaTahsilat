using FaturaTahsilat.Core.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IKullaniciRepository Kullanici { get; }
        IFaturaRepository Fatura { get; }
        Task CommitAsync();
        void Commit();
    }
}
