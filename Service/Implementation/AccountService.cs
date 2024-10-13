using Domain.Common;
using Persistence.RepositoryContract;
using Service.Contract;

namespace Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryManager _repositoryManager;
        public AccountService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Response<dynamic>> Login(string username, string password)
        {
            return await _repositoryManager.AccountRepository.Login(username,password);
        }
    }
}
