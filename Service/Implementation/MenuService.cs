using Persistence.RepositoryContract;
using Service.Contract;

namespace Service.Implementation
{
    public class MenuService : IMenuService
    {
        private readonly IRepositoryManager _repositotyManager;
        public MenuService(IRepositoryManager repositoryManager) 
        {
            _repositotyManager = repositoryManager;
        }
    }
}
