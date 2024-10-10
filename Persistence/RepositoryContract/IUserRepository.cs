using Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.RepositoryContract
{
    public interface IUserRepository
    {
        Task<bool> AddUser(AddUserReq req);
    }
}
