using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.Domain.Core.Invitations.Interfaces.Repositories
{
    public interface IGuestsRepository
    {
        Task<IEnumerable<Guest>> GetGuestInEvent(Event eventToFilter);
        Task<IEnumerable<Guest>> GetGuests(List<Guid> ids);
        Task SaveChangeAsync();
    }
}