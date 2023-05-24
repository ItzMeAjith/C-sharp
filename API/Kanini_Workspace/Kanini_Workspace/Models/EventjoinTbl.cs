using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class EventjoinTbl
{
    public int EventjoinId { get; set; }

    public int? TotalEventjoin { get; set; }

    public virtual EventTbl Eventjoin { get; set; } = null!;
}
