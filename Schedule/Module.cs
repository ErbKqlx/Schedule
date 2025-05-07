using System;
using System.Collections.Generic;

namespace Schedule;

public partial class Module
{
    public short Id { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<Curriculum> Curricula { get; set; } = new List<Curriculum>();
}
