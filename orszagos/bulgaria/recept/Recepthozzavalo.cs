using System;
using System.Collections.Generic;

namespace ReceptAPI.Models;

public partial class Recepthozzavalo
{
    public int Receptid { get; set; }

    public int HozzavaloId { get; set; }

    public string Mennyiseg { get; set; } = null!;

    public virtual Hozzavalo? Hozzavalo { get; set; } = null!;

    public virtual Recept? Recept { get; set; } = null!;
}
