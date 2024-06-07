using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VehicalRentalSystem1.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Cookies["jwt"];
                
            if (token != null)
            {
                await ValidateTokenAndAuthenticateUser(context, token);
            }

            await _next(context);
        }
        private async Task ValidateTokenAndAuthenticateUser(HttpContext context, string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidIssuer = "AditeeKhedekar",
                ValidAudience = "your_audience",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ythguritjghtyurfgtedwsujikoltgyh"))
            };

            try
            {
                // Extract and validate claims from the token
                var principal = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);

                // Ensure the token has required claims
                if (principal == null || !principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    context.Response.StatusCode = 401; // Unauthorized
                    await context.Response.WriteAsync("Unauthorized: Invalid token claims");
                    return;
                }

                // Perform additional user authentication if needed
                // Example: Check if the user exists in the database

                // Set authenticated user principal
                context.User = principal;
            }
            catch (SecurityTokenExpiredException ex)
            {
                context.Response.StatusCode = 401; // Unauthorized
                Console.WriteLine(ex.Message);
            }
            catch (SecurityTokenException ex)
            {
                context.Response.StatusCode = 401; // Unauthorized
               Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 401; // Unauthorized
                Console.WriteLine(ex.Message);
            }
        }
    }
}