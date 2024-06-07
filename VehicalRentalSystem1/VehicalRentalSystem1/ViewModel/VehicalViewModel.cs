using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.ViewModel;

namespace VehicalRentalSystem1.ViewModel
{
    public class VehicalViewModel
    {
        public VehicalViewModel()
        {
            VehicalId = Guid.NewGuid();
            //UserId = Guid.NewGuid();
        }
        public Guid VehicalId { get; set; }

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public string Type { get; set; } = null!;

        public string LicenseNo { get; set; }

        public string Color { get; set; } = null!;

        public int Mileage { get; set; }

        public bool AvailabilityStatus { get; set; }

        public int RentalRatePerHour { get; set; }

        public bool InsuranceAvailable { get; set; }

        public IFormFile? Vehical_Photo { get; set; }
        public string? InsuranceInfo { get; set; }
        public Guid UserId { get; set; }
    }
}
