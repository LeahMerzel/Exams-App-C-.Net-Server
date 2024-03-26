using Exams_App_C__.Net_Server.Data.DB;
using Microsoft.EntityFrameworkCore;
using Exams_App_C__.Net_Server.Core.Interfaces;
using Exams_App_C__.Net_Server.Repositories;
using Exams_App_C__.Net_Server.Data.Models;

namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class AuthRepository : GenericRepository<User>, IAuthRepository
    {
        private User? _user;
        public AuthRepository(
            ExamsDbContext dbContext
        ) : base(dbContext) { }

        public async Task<User?> LoginAsync(User userLogin)
        {
            _user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == userLogin.Email && u.PasswordHash == userLogin.PasswordHash);

            if (_user == null)
            {
                return null;
            }

            return _user;
        }

        public async Task<int> RegisterAsync(User registerUser)
        {
            if (string.IsNullOrEmpty(registerUser.UserName) ||
                string.IsNullOrEmpty(registerUser.FullName) ||
                string.IsNullOrEmpty(registerUser.Email) ||
                string.IsNullOrEmpty(registerUser.PasswordHash) ||
                string.IsNullOrEmpty(registerUser.UserRole))
            {
                return 0;
            }

            var isUserEmailExists = dbContext.Users.FirstOrDefault(u => u.Email == registerUser.Email);
            if (isUserEmailExists != null)
            {
                return 0;
            }

            User newUser = new User
            {
                UserName = registerUser.UserName,
                FullName = registerUser.FullName,
                Email = registerUser.Email,
                PasswordHash = registerUser.PasswordHash,
                UserRole = registerUser.UserRole
            };

            dbContext.Users.Add(newUser);

            await dbContext.SaveChangesAsync();

            return 1;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            _user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (_user == null)
            {
                return false;
            }

            try
            {
                UpdateUserDetails(user);
                dbContext.Entry(_user).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return true;
        }

        public void UpdateUserDetails(User user)
        {
            _user!.UserName = user.UserName;
            _user.Email = user.Email;
            _user.FullName = user.FullName;
            _user.PasswordHash = user.PasswordHash;
        }

        public async Task<User?> GetUser(string UserId)
        {
            var user = await dbContext.Users.SingleOrDefaultAsync(u => u.Id == UserId);
            return user;
        }
    }
}