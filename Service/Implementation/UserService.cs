using Domain.Common;
using Domain.User;
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

        public async Task<Response<dynamic>> AddUser(AddUserReq req)
        {
            return await _repositoryManager.UserRepository.AddUser(req);
        }
    }
}
