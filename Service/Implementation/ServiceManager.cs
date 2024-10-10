using Persistence;
using Persistence.RepositoryContract;
using Persistence.RepositoryImplementation;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly Lazy<IUserService> _userService;


        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
            _userService = new Lazy<IUserService>(() => new UserService(_repositoryManager));
        }

        public IUserService UserService => _userService.Value;

    }
}
