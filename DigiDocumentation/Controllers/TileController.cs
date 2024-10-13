using Domain.Tile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence.RepositoryContract;
using Service.Contract;

namespace DigiDocumentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TileController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TileController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetTile()
        {
            var response = await this._serviceManager.TileService.GetTitle();
            return Ok(response);
        }
    }
}
