using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VehicalRentalSystem1.Models;
using System.Text;
using System.Security.Cryptography;

namespace VehicalRentalSystem1.Services
{
    public class RegistrationService
    {
        private readonly ValidationService _validationService;
        private const string EncryptionKey = "sdefrgthyjukilok";
        private const string IV = "YourIV1234567890"; 
        public RegistrationService(ValidationService userService)
        {
            _validationService = userService;
        }

        public IActionResult Register(User user, ModelStateDictionary modelState, string successMessage, string loginAction)
        {
            if (modelState.IsValid)
            {
                if (_validationService.EmailExists(user.Email))
                {
                    string messege = "Email address is already registered.";
                    modelState.AddModelError("Email", messege);
                    return null;
                }
                if (!_validationService.BothPassword(user.Password1, user.Password2))
                {
                    string messege = "Both Passwords are not same.";
                    modelState.AddModelError("Password", messege);
                    return null;
                }
                if (!_validationService.IsPasswordValid(user.Password1))
                {
                    string messege = "Password must be at least 6 characters long and contain at least one capital letter and one number.";
                    modelState.AddModelError("Password", messege);
                    return null;
                }

                _validationService.RegisterUser(user);
                return new RedirectToActionResult(loginAction, "Home", null);
            }
            return null;
        }


        public string EncryptPassword(string password)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = Encoding.UTF8.GetBytes(IV);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
    }
}
