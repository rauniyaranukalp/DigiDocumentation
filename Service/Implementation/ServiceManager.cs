using Persistence.RepositoryContract;
using Service.Contract;

namespace Service.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAccountService> _accountService;
        private readonly Lazy<IMenuService> _menuService;


        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
            _userService = new Lazy<IUserService>(() => new UserService(_repositoryManager));
            _accountService = new Lazy<IAccountService>(() => new AccountService(_repositoryManager));
            _menuService = new Lazy<IMenuService>(() => new MenuService(_repositoryManager));
        }

        public IUserService UserService => _userService.Value;
        public IAccountService AccountService => _accountService.Value;
        public IMenuService MenuService => _menuService.Value;

    }
}
