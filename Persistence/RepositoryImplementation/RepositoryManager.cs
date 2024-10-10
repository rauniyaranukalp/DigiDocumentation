using Persistence.RepositoryContract;
namespace Persistence.RepositoryImplementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly MongoDbConnection _mongoDbConnection;
        private readonly Lazy<IUserRepository> _userRepository;

        //public RepositoryManager()
        //{
            
        //}
        public RepositoryManager(MongoDbConnection mongoDbConnection)
        {
            _mongoDbConnection = mongoDbConnection;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_mongoDbConnection));
        }

        public IUserRepository UserRepository => _userRepository.Value;
    }
}
