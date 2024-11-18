using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contaseña { get; set; }
}
