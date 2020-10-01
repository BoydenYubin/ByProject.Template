using System.Threading.Tasks;

namespace ByProject.Domain.Core.Events
{
    public interface IEventStoreService
    {
        Task Save<T>(T @event) where T : Event;
    }
}
