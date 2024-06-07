using System.Linq;
using VehicalRentalSystem1.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace VehicalRentalSystem1.Services
{
    public class ValidationService
    {
        private readonly VehicalRentalSystemContext _context;

        public ValidationService(VehicalRentalSystemContext context)
        {
            _context = context;
        }

        public User Authenticate(string email, string password)
        {
            // return _context.Users.FirstOrDefault(x => x.Email == email && x.Password1 == password) ?? new User();

            return _context.Users.Where(x => x.Email == email && x.Password1 == password).FirstOrDefault();
        }

        public bool RegisterUser(User user)
        {
            if (EmailExists(user.Email))
                return false;

            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool EmailExists(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
        public User GetUserByEmail(string email)
        {
            // Retrieve the user from the database based on the email
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }
        public bool Age(int? age)
        {
            if (age < 18)
            {
                return false;
            }
            return true;
        }

        public bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(@"
                           + @"(([-a-z0-9]|(?<!\.)\.)*[a-z0-9])|"
                           + @"(\[([0-9]{1,3}\.){3}[0-9]{1,3}\]))$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

        }

        public bool IsValidPhoneNumber(long phoneNumber)
        {
            if (phoneNumber >= 1000000 && phoneNumber <= 999999999999999)
            {
                return true;
            }
            return false;
        }
        public bool BothPassword(string password1, string password2)
        {
            return password1 == password2;
        }

        public bool IsPasswordValid(string password)
        {
            return password.Length >= 6 && password.Any(char.IsUpper) && password.Any(char.IsDigit);
        }


        //jwt validation
        public static ClaimsPrincipal ValidateToken(string token, string key)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var keyBytes = Encoding.ASCII.GetBytes(key);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out _);
                return principal;
            }
            catch (Exception ex)
            {
                // Token validation failed
                // You can log or handle this exception accordingly
                // For simplicity, I'm not handling the exception here
                throw new Exception("Token validation failed", ex);
            }
        }
    }
}