using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Cabinet
{
    public short Id { get; set; }

    public short Number { get; set; }

    public short IdBuilding { get; set; }

    public virtual Building IdBuildingNavigation { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
