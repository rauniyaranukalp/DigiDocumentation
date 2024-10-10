using Domain.User;
using Persistence;
using Persistence.RepositoryContract;
using Service.Contract;

namespace Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        public UserService(IRepositoryManager repositoryManager) 
        { 
            _repositoryManager = repositoryManager;
        }

        public async Task<bool> AddUser(AddUserReq req)
        {
            return await _repositoryManager.UserRepository.AddUser(req);
        }
    }
}
