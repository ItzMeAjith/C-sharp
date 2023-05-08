using System;
using System.Collections.Generic;

namespace Online_Education_Provider.Models;

public partial class Quiz
{
    public int QuizId { get; set; }

    public string? QuizName { get; set; }

    public string? QuizDifLevel { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
