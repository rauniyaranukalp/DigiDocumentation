using Domain.Common;
using Domain.Tile;

namespace Service.Contract
{
    public interface ITileService
    {
        Task<Response<bool>> AddTile(AddTileReq model);
    }
}
