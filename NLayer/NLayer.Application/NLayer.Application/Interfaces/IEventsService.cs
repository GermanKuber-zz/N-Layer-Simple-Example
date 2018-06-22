using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NLayer.Application.Dtos;

namespace NLayer.Application.Interfaces
{
    public interface IEventsService
    {
        Task<IEnumerable<EventDto>> GetEvents(EventFilterDto filter);
        Task<EventDto> GetEvent(Guid id);
        Task<IEnumerable<EventDto>> GetEvents( );
        Task InviteGuestToEvent(List<Guid> guestsToInvite, Guid idEventToInvite);
    }
}