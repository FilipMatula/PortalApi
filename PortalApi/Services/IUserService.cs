using PortalApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<User> GetById(int id);
        Task<User> GetByEmail(string email);
        Task<User> Create(User user, string password);
        Task<string> SetEmailConfirmationToken(int userId);
        Task<string> ResetPassword(string userEmail);
        Task ConfirmEmail(int userId, string token);
        Task Update(User user, string password = null);
        Task Delete(int id);
        Task<bool> SaveChangesAsync();
    }
}