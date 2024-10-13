using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IAccountService
    {
        Task<Response<dynamic>> Login(string username, string password);
    }
}
