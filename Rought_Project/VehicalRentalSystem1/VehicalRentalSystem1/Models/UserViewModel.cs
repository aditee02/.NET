
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using VehicalRentalSystem1.Models;

namespace VehicalRentalSystem1.Models
{
    public class UserViewModel
    {

        public UserViewModel()
        {
            UserId = Guid.NewGuid();
        }

        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; } = null!;


        [Required]
        public string? Email { get; set; }


        [Required]
        public int? Age { get; set; }


        [Required]
        public long PhoneNo { get; set; }


        [Required]
        public string? Address { get; set; }

        public string Username { get; set; }

        //public string ResetToken { get; set; } = "1";

        [Required]
        [DataType(DataType.Password)]
        public string Password1 { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password2 { get; set; } = null!;

        [Required(ErrorMessage = "Please upload the government document image.")]
        public IFormFile GovernmentDocImage { get; set; }
    }
}
