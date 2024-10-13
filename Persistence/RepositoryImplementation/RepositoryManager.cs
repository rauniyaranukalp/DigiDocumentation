using Persistence.RepositoryContract;
namespace Persistence.RepositoryImplementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly MongoDbConnection _mongoDbConnection;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAccountRepository> _accountRepository;
        private readonly Lazy<IMenuRepository> _menuRepository;
        public RepositoryManager(MongoDbConnection mongoDbConnection)
        {
            _mongoDbConnection = mongoDbConnection;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_mongoDbConnection));
            _accountRepository = new Lazy<IAccountRepository>(() => new AccountRepository(_mongoDbConnection));
            _accountRepository = new Lazy<IMenuRepository>(() => new MenuRepository(_mongoDbConnection));
        }

        public IUserRepository UserRepository => _userRepository.Value;
        public IAccountRepository AccountRepository => _accountRepository.Value;
        public IMenuRepository MenuRepository => _menuRepository.Value;
    }
}
