using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Seguro
{
    public int Id { get; set; }

    public byte[]? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();
}
