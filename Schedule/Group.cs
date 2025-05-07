using System;
using System.Collections.Generic;

namespace Schedule;

public partial class Group
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public short Course { get; set; }

    public DateOnly DateOfAdmission { get; set; }

    public DateOnly DateOfGraduation { get; set; }

    public short IdTeacher { get; set; }

    public short IdCurriculum { get; set; }

    public virtual Curriculum IdCurriculumNavigation { get; set; } = null!;

    public virtual Teacher IdTeacherNavigation { get; set; } = null!;
}
