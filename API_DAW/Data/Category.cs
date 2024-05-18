using System;
using System.Collections.Generic;

namespace API_DAW.Data;

public partial class Category
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }
}
