using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class DisciplinesTeacher
{
    public short Id { get; set; }

    public short IdDiscipline { get; set; }

    public short? IdTeacher { get; set; }

    public virtual Discipline IdDisciplineNavigation { get; set; } = null!;

    public virtual Teacher? IdTeacherNavigation { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
