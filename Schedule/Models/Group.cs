using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Group
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public short Course { get; set; }

    public short IdTeacher { get; set; }

    public short YearOfAdmission { get; set; }

    public short YearOfGraduation { get; set; }

    public virtual Teacher IdTeacherNavigation { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
