namespace VehicalRentalSystem1.ViewModel
{
    public class ProfileViewModel
    {
        public ProfileViewModel() { 
            UserId = Guid.NewGuid();
        }

    public Guid UserId { get; set; }

 
    public string Name { get; set; } = null!;



    public string? Email { get; set; }



    public int? Age { get; set; }



    public long PhoneNo { get; set; }


    public string? Address { get; set; }

    public string Username { get; set; }

   
    public string? GovernmentDocImage { get; set; }

        public string? Password1 { get; set; } 
        public string? Password2 { get; set; } 


    }
}
