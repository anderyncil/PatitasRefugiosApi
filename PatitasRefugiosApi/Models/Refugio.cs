using System;

namespace PatitasRefugiosApi.Models;

public class Refugio
{
    public string IdRefugio { get; set; } = Guid.NewGuid().ToString();
    public string Nombre { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public double Latitud { get; set; }
    public double Longitud { get; set; }
    public string Correo { get; set; } = string.Empty;
    public string NumCelular { get; set; } = string.Empty;
    public string FotoUrl { get; set; } = string.Empty;
}
