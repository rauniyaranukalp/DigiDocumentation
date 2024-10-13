using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace DigiDocumentation.Controllers
{
    public class MenuController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public MenuController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


    }
}
