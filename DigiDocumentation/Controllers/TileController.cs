using Domain.Tile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence.RepositoryContract;

namespace DigiDocumentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TileController : ControllerBase
    {
        private readonly ITileRepository _tileRepository;
        public TileController(ITileRepository tileRepository)
        {
            _tileRepository = tileRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddTile(AddTileReq model)
        {
            var response = await this._tileRepository.AddTile(model);
            return Ok(response);
        }
    }
}
