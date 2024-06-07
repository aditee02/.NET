using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Feedback
{
    public Guid FeedbackId { get; set; }

    public Guid TransactionId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public virtual RentalTransaction Transaction { get; set; } = null!;
}
