namespace VehicalRentalSystem1.ViewModel
{
    public class BookingViewModel
    {
        public BookingViewModel()
        {
            BookingId = Guid.NewGuid();
        }
        public Guid BookingId { get; set; }

        public Guid UserId { get; set; }

        public Guid VehicalId { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public decimal TotalRentalCost { get; set; }

        public bool InsuranceOption { get; set; }

        public string PickupLocation { get; set; } = null!;

        public string DropOffLocation { get; set; } = null!;

        public decimal? AdditionalCharges { get; set; }

    }
}
