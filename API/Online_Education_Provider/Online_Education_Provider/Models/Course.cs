using System;
using System.Collections.Generic;

namespace Online_Education_Provider.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseDuration { get; set; }

    public decimal? CourseFees { get; set; }

    public int? CourseRating { get; set; }

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
