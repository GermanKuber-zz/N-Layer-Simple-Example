using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayer.Domain.Core.Invitations;
using NLayer.Domain.Core.Invitations.Interfaces.Repositories;
using NLayer.Infraestructure.Invitations.Data.Context;

namespace NLayer.Infraestructure.Invitations.Data.Repositories
{
    public class EventsSqlRepository : BaseRepository, IEventsRepository
    {
        public EventsSqlRepository(NLayerIntivationsContext context) : base(context)
        {
        }

        public void Add(Event eventToAdd) => Context.Add(eventToAdd);

        public async Task<IEnumerable<Event>> GetEvents(DateTime startDate, DateTime endDate) =>
            await Context.Events
                .Where(x => x.Date > startDate && x.Date < endDate)
                .ToListAsync();

        public async Task<Event> GetEventAsync(Guid id) =>
            await Context.Events
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<Event>> GetEvents() =>
                await Context.Events
                             .ToListAsync();
    }
}