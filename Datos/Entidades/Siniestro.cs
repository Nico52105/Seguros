using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Siniestro
{
    public int Id { get; set; }

    public int? IdAdquisicion { get; set; }

    public DateOnly? FechaSiniestro { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public virtual Adquisicione? IdAdquisicionNavigation { get; set; }
}
