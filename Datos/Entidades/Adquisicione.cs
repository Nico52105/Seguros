using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Adquisicione
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdPoliza { get; set; }

    public DateOnly? FechaAdquisicion { get; set; }

    public string? Estado { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Poliza? IdPolizaNavigation { get; set; }

    public virtual ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
}
