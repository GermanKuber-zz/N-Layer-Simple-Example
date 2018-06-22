using Microsoft.EntityFrameworkCore;
using NLayer.Domain.Core.Invitations;

namespace NLayer.Infraestructure.Invitations.Data.Context
{
    public class NLayerIntivationsContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
