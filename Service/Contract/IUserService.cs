using Domain.Common;
using Domain.User;

namespace Service.Contract
{
    public interface IUserService
    {
        Task<Response<dynamic>> AddUser(AddUserReq req);
    }
}
