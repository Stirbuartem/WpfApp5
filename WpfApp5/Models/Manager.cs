﻿using System;
using System.Collections.Generic;

namespace WpfApp5.Models;

public partial class Manager
{
    public int Idmanager { get; set; }

    public int Iduser { get; set; }

    public virtual Course IdmanagerNavigation { get; set; } = null!;

    public virtual User? User { get; set; }
}
