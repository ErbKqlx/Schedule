using System;
using System.Collections.Generic;

namespace Schedule;

public partial class Curriculum
{
    public short Id { get; set; }

    public short IdModule { get; set; }

    public short IdDiscipline { get; set; }

    public string Name { get; set; } = null!;

    public short Hours1 { get; set; }

    public short Hours2 { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual Discipline IdDisciplineNavigation { get; set; } = null!;

    public virtual Module IdModuleNavigation { get; set; } = null!;
}
