using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Booking
{
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

    public virtual ICollection<Damage>? Damages { get; set; } = new List<Damage>();

    public virtual ICollection<Payment>? Payments { get; set; } = new List<Payment>();

    public virtual User? User { get; set; } = null!;
}
