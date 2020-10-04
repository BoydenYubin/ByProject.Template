using System;
using System.Threading.Tasks;

namespace ByProject.Domain.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
