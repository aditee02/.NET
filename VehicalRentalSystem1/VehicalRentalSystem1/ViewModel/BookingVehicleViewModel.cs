namespace VehicalRentalSystem1.ViewModel
{
    public class BookingVehicleViewModel
    {
        //vehicle
        public BookingVehicleViewModel()
        {
            BookingId = Guid.NewGuid();
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

        public String? Vehical_Photo { get; set; }
        public string? InsuranceInfo { get; set; }
        public Guid UserId { get; set; }


        //booking
        public Guid BookingId { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public decimal TotalRentalCost { get; set; }

        public bool InsuranceOption { get; set; }

        public string PickupLocation { get; set; } = null!;

        public string DropOffLocation { get; set; } = null!;

        public decimal? AdditionalCharges { get; set; }
    }
}
