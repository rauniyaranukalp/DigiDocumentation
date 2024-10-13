using Persistence.RepositoryContract;
namespace Persistence.RepositoryImplementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly MongoDbConnection _mongoDbConnection;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAccountRepository> _accountRepository;
        private readonly Lazy<IMenuRepository> _menuRepository;
        private readonly Lazy<ITileRepository> _tileRepository;
        public RepositoryManager(MongoDbConnection mongoDbConnection)
        {
            _mongoDbConnection = mongoDbConnection;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_mongoDbConnection));
            _accountRepository = new Lazy<IAccountRepository>(() => new AccountRepository(_mongoDbConnection));
            _menuRepository = new Lazy<IMenuRepository>(() => new MenuRepository(_mongoDbConnection));
            _tileRepository = new Lazy<ITileRepository>(() => new TileRepository(_mongoDbConnection));
        }

        public IUserRepository UserRepository => _userRepository.Value;
        public IAccountRepository AccountRepository => _accountRepository.Value;
        public IMenuRepository MenuRepository => _menuRepository.Value;
        public ITileRepository TileRepository => _tileRepository.Value;
    }
}
