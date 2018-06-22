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
    public class GuestsSqlRepository : BaseRepository, IGuestsRepository
    {
        public GuestsSqlRepository(NLayerIntivationsContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Guest>> GetGuestInEvent(Event eventToFilter) => 
            await Context.Events
                .Where(x => x.Equals(eventToFilter))
                .SelectMany(x => x.Guests)
                .ToListAsync();

        public async Task<IEnumerable<Guest>> GetGuests(List<Guid> ids) =>
            await Context.Guests
                .Where(x => ids.Contains(x.Id))
                .ToListAsync();
    }
}