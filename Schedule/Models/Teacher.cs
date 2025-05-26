using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Teacher
{
    public short Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public virtual ICollection<DisciplinesTeacher> DisciplinesTeachers { get; set; } = new List<DisciplinesTeacher>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public string FullName => $"{Surname} {Name} {Patronymic}";
}
