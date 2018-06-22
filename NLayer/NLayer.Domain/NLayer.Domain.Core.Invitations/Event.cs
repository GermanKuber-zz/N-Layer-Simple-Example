using System;
using System.Collections.Generic;
using System.Linq;

namespace NLayer.Domain.Core.Invitations
{
    public class Event
    {
        public Guid Id { get; protected set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Room Room { get; protected set; }
        public List<Guest> Guests { get; protected set; } = new List<Guest>();

        public Event(string name, DateTime date, Room room)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (room == null)
                throw new ArgumentNullException(nameof(room));
            Name = name;
            Date = date;
            Room = room;
        }

        public void Invite(Guest guest)
        {
            if (!Guests.Any(x => x.Equals(guest)))
                Room.AddGuest(() => Guests.Add(guest));
        }

    }
}