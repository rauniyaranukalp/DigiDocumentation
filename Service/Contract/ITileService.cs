using Domain.Common;
using Domain.Tile;

namespace Service.Contract
{
    public interface ITileService
    {
        Task<Response<List<TileResModel>>> GetTitle();

    }
}
