﻿using System;
using System.Collections.Generic;

namespace Online_Education_Provider.Models;

public partial class UserRegistration
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? MailId { get; set; }

    public string? Password { get; set; }
}
