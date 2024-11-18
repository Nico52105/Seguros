using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Cotizacione
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdPoliza { get; set; }

    public DateOnly? FechaCotizacion { get; set; }

    public string? Monto { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Poliza? IdPolizaNavigation { get; set; }
}
