using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Poliza
{
    public int Id { get; set; }

    public int? IdSeguro { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Prima { get; set; }

    public string? Cobertura { get; set; }

    public string? Condiciones { get; set; }

    public virtual ICollection<Adquisicione> Adquisiciones { get; set; } = new List<Adquisicione>();

    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();

    public virtual Seguro? IdSeguroNavigation { get; set; }
}
