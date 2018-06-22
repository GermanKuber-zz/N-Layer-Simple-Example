using System;

namespace NLayer.Domain.Core.Invitations
{
    public class Guest
    {
        public Guid Id { get; protected set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}