using System;
using System.Collections.Generic;

namespace Schedule;

public partial class Subject
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TeachersSubject> TeachersSubjects { get; set; } = new List<TeachersSubject>();
}
