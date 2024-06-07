using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Vehical
{
    public Guid VehicalId { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public string Type { get; set; } = null!;

    public Guid LicenseNo { get; set; }

    public string Color { get; set; } = null!;

    public int Mileage { get; set; }

    public bool AvailabilityStatus { get; set; }

    public int RentalRatePerHour { get; set; }

    public bool InsuranceAvailable { get; set; }

    public string? InsuranceInfo { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
