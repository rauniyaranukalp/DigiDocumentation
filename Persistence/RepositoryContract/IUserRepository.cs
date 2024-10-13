using Domain.Common;
using Domain.User;

namespace Persistence.RepositoryContract
{
    public interface IUserRepository
    {
        Task<Response<dynamic>> AddUser(AddUserReq req);
    }
}
