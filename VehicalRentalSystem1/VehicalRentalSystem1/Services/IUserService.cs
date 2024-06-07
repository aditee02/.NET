using System.Threading.Tasks;
using VehicalRentalSystem1.Models;


namespace VehicalRentalSystem1.Services
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string email);
        Task UpdateUser(User user);
    }
}