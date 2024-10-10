using Domain.User;

namespace Service.Contract
{
    public interface IUserService
    {
        Task<bool> AddUser(AddUserReq req);
    }
}
