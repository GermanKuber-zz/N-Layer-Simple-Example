using System;
using System.Collections.Generic;
using System.Linq;
using NLayer.Domain.Core.Invitations;

namespace NLayer.Application.Dtos
{
    public class EventDto
    {
        public Guid Id { get; protected set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<GuestDto> Guests { get; protected set; }

        public EventDto(Event eventResult)
        {
            Id = eventResult.Id;
            Name = eventResult.Name;
            Date = eventResult.Date;
            Guests = eventResult.Guests
                .Select(x=> new GuestDto(x))
                .ToList();
        }

        public EventDto()
        {
            
        }
    }
}