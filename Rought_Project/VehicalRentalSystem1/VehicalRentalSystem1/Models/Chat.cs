using System;
using System.Collections.Generic;

namespace VehicalRentalSystem1.Models;

public partial class Chat
{
    public Guid ChatId { get; set; }

    public Guid? SuserId { get; set; }

    public Guid? RuserId { get; set; }

    public DateTime ConversationStartTime { get; set; }

    public string MessegeContext { get; set; } = null!;

    public virtual User? Ruser { get; set; }

    public virtual User? Suser { get; set; }
}
