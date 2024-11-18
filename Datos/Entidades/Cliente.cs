using Contratos;
using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Adquisicione> Adquisiciones { get; set; } = new List<Adquisicione>();

    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();
}
