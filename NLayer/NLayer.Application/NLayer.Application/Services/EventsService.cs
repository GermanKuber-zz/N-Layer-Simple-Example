using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLayer.Application.Dtos;
using NLayer.Application.Interfaces;
using NLayer.Domain.Core.Invitations.Interfaces.Repositories;

namespace NLayer.Application
{
    public class EventsService : IEventsService
    {
        private readonly IEventsRepository _eventsRepository;
        private readonly IGuestsRepository _guestsRepository;

        public EventsService(IEventsRepository eventsRepository,
                             IGuestsRepository guestsRepository)
        {
            _eventsRepository = eventsRepository;
            _guestsRepository = guestsRepository;
        }

        public async Task<IEnumerable<EventDto>> GetEvents()
        {
            var eventResult = await _eventsRepository.GetEvents();
            return eventResult.Select(x => new EventDto(x));
        }

        public async Task<EventDto> GetEvent(Guid id)
        {
            var eventResult = await _eventsRepository.GetEventAsync(id);
            return new EventDto(eventResult);
        }

        public async Task InviteGuestToEvent(List<Guid> guestsToInvite, Guid idEventToInvite)
        {
            var eventToInvite = await _eventsRepository.GetEventAsync(idEventToInvite);
            var guests = await _guestsRepository.GetGuests(guestsToInvite);

            guests.ToList()
                  .ForEach(g => eventToInvite.Invite(g));

            await _guestsRepository.SaveChangeAsync();
        }

        public async Task<IEnumerable<EventDto>> GetEvents(EventFilterDto filter)
        {
            var eventResult = await _eventsRepository.GetEvents(filter.StartDate, filter.EndDate);

            return eventResult.Select(x => new EventDto(x))
                              .ToList();
        }
    }
}
