﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIMission10_Herm.Something;

public partial class Bowler
{
    [Key]
    [Required]
    public int BowlerId { get; set; }

    public string? BowlerLastName { get; set; }

    public string? BowlerFirstName { get; set; }

    public string? BowlerMiddleInit { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }

    public string? BowlerPhoneNumber { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
