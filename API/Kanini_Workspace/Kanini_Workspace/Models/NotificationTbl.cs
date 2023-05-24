using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class NotificationTbl
{
    public int NotifId { get; set; }

    public string NotifTitle { get; set; } = null!;

    public int NotifLoc { get; set; }

    public TimeSpan NotifTime { get; set; }

    public DateTime NotifDate { get; set; }

    public string NotifDesc { get; set; } = null!;

    public virtual LocationTbl NotifLocNavigation { get; set; } = null!;
}
