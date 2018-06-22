using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.Domain.Core.Invitations.Interfaces.Repositories
{
    public interface IEventsRepository
    {
        void Add(Event eventToAdd);
        Task<IEnumerable<Event>> GetEvents(DateTime startDate, DateTime endDate);
        Task<Event> GetEventAsync(Guid id);
        Task<IEnumerable<Event>> GetEvents();
        Task SaveChangeAsync();
    }
}