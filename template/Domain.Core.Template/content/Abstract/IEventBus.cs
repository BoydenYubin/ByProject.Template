using ByProject.Domain.Core.Commands;
using ByProject.Domain.Core.Events;
using System.Threading.Tasks;

namespace ByProject.Domain.Core.Bus.Abstract
{
    public interface IEventBus
    {
        Task<bool> SendCommand<T>(T command) where T : Command;
        Task Publish<T>(T @event) where T : Event;
    }
}
