using PortalApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<User> GetById(int id);
        Task<User> Create(User user, string password);
        Task<string> SetEmailConfirmationToken(int userId);
        Task ConfirmEmail(int userId, string token);
        Task Update(User user, string password = null);
        Task Delete(int id);
    }
}