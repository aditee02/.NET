using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicalRentalSystem1.Models;

public partial class User
{

    public User()
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



    //[Required(ErrorMessage = "Please upload the government document.")]
    //public string? GovernmentDoc { get; set; }

    [Required]
    public string? GovernmentDoc { get; set; }
    public string Username { get; set; }

    //public string ResetToken { get; set; } = "1";

    [Required]
    [DataType(DataType.Password)]
    public string Password1 { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    public string Password2 { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Chat> ChatRusers { get; set; } = new List<Chat>();

    public virtual ICollection<Chat> ChatSusers { get; set; } = new List<Chat>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Vehical> Vehicals { get; set; } = new List<Vehical>();

}
