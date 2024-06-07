
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicalRentalSystem1.Models;

namespace VehicalRentalSystem1.Services
{
    public class UserService : IUserService
    {

        private readonly VehicalRentalSystemContext _dbContext;

        public UserService(VehicalRentalSystemContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  Task<User> GetUserByEmail(string email)
        {
            return  _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}