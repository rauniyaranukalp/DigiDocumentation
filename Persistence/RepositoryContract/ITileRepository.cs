using Domain.Common;
using Domain.Tile;

namespace Persistence.RepositoryContract
{
    public interface ITileRepository
    {
        Task<Response<List<TileResModel>>> GetTitle();
    }
}
