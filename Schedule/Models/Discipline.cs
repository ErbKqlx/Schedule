using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Discipline
{
    public short Id { get; set; }

    public string? Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<DisciplinesTeacher> DisciplinesTeachers { get; set; } = new List<DisciplinesTeacher>();

    public string CodeName => $"{Code} {Name}";
}
