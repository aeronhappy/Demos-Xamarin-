using Demos.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Services.Interfaces
{
    public interface IHttpClientRepository
    {
        Task<Accounts> GetAccountsAsync();
        Task<Chapter> GetVerse();
        Task<Response> RegisterAsync(RegisterDto credentials);
        Task<VersionApp> GetVersion();
        Task<Cool> GetCool();

        Task<Page<Community>> GetCommunity(int pageNumber, int pageSize);
    }
}
