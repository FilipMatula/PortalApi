using PortalApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string email, string password);
        Task<User> GetByIdAsync(int id);
        Task<User> GetByEmailAsync(string email);
        Task<User> CreateAsync(User user, string password);
        Task<string> SetEmailConfirmationTokenAsync(int userId);
        Task<string> ResetPasswordAsync(string userEmail);
        Task ConfirmEmailAsync(int userId, string token);
        Task UpdateAsync(User user, string password = null);
        Task DeleteAsync(int id);
        Task<bool> SaveChangesAsync();
    }
}