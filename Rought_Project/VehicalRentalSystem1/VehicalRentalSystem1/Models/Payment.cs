using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Payment
{
    public Guid PaymentId { get; set; }

    public Guid UserId { get; set; }

    public Guid BookingId { get; set; }

    public Guid DamageId { get; set; }

    public decimal TotalPayment { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

    public virtual User User { get; set; } = null!;
}
