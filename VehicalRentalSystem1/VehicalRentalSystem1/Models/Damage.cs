using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Damage
{
    public Guid DamageId { get; set; }

    public Guid BookingId { get; set; }

    public string DescriptionOfDamage { get; set; } = null!;

    public byte[] DamageImage { get; set; } = null!;

    public decimal Cost { get; set; }

    public decimal InsuranceCoverage { get; set; }

    public decimal TotalDamageCost { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
