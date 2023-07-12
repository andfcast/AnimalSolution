using System;
using System.Collections.Generic;

namespace AnimalEntities.DBEntities;

public partial class Animal
{
    public int AnimalId { get; set; }

    public string Name { get; set; } = null!;

    public string Breed { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Sex { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Status { get; set; }
}
