using System.Threading.Tasks;
using NLayer.Infraestructure.Invitations.Data.Context;

namespace NLayer.Infraestructure.Invitations.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly NLayerIntivationsContext Context;

        public BaseRepository(NLayerIntivationsContext context)
        {
            Context = context;
        }
        public async Task SaveChangeAsync() => await Context.SaveChangesAsync();

    }
}