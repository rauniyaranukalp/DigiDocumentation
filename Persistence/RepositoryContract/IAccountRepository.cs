using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.RepositoryContract
{
    public interface IAccountRepository
    {
        Task<Response<dynamic>> Login(string username, string password);
    }
}
