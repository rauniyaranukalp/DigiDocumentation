using Domain.Common;

namespace Service.Contract
{
    public interface IAccountService
    {
        Task<Response<dynamic>> Login(string username, string password);
    }
}
