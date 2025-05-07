using System;
using System.Collections.Generic;

namespace Schedule;

public partial class TeachersSubject
{
    public short Id { get; set; }

    public short IdTeacher { get; set; }

    public short IdSubject { get; set; }

    public virtual Subject IdSubjectNavigation { get; set; } = null!;

    public virtual Teacher IdTeacherNavigation { get; set; } = null!;
}
