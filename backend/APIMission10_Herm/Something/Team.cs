using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMission10_Herm.Something;

public partial class Team
{
    [Key]
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;
    [ForeignKey("Team")]
    public int? CaptainId { get; set; }

    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
}
