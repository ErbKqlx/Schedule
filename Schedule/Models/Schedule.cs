using System;
using System.Collections.Generic;

namespace Schedule_project.Models;

public partial class Schedule
{
    public short Id { get; set; }

    public short IdGroup { get; set; }

    public short? IdCabinet { get; set; }

    public short Number { get; set; }

    public short IdDisciplineTeacher { get; set; }

    public DateOnly Date { get; set; }

    public virtual Cabinet? IdCabinetNavigation { get; set; }

    public virtual DisciplinesTeacher IdDisciplineTeacherNavigation { get; set; } = null!;

    public virtual Group IdGroupNavigation { get; set; } = null!;
}
