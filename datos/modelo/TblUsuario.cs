using System;
using System.Collections.Generic;

namespace datos.modelo;

public partial class TblUsuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public int TipoIdDocumento { get; set; }

    public string? Password { get; set; }
}
