using Exams_App_C__.Net_Server.Data.Models;

namespace Exams_App_C__.Net_Server.Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<User?> GetUser(string UserId);
        Task<User?> LoginAsync(User userLogin);
        Task<int> RegisterAsync(User registerUser);
        Task<bool> UpdateUserAsync(User user);
        void UpdateUserDetails(User user);
    }
}