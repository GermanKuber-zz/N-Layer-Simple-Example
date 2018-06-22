using System;
using NLayer.Domain.Core.Invitations;

namespace NLayer.Application
{
    public class GuestDto
    {
        public Guid Id { get; protected set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public GuestDto(Guest guest)
        {
            Id = guest.Id;
            Name = guest.Name;
            LastName = guest.LastName;
        }

        public GuestDto()
        {
            
        }
    }
}