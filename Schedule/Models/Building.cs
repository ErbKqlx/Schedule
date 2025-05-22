using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Building
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public virtual ICollection<Cabinet> Cabinets { get; set; } = new List<Cabinet>();
}
