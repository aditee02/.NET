using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class RentalTransaction
{
    public Guid TransactionId { get; set; }

    public Guid PaymentId { get; set; }

    public decimal Amount { get; set; }

    public DateTime TransactionDate { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public byte[] ProofOfPayment { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual Payment Payment { get; set; } = null!;
}
