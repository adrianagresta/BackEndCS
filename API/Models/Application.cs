using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Application
{
    public int Id { get; set; }

    public string Company { get; set; } = null!;

    public DateOnly? Applydate { get; set; }

    public DateOnly? Rejectdate { get; set; }

    public int? Salarymin { get; set; }

    public int? Salarymax { get; set; }

    public string? Link { get; set; }

    public bool Applied { get; set; }

    public bool Rejected { get; set; }

    public string? Location { get; set; }
}
