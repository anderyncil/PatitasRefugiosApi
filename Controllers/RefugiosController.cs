using Microsoft.AspNetCore.Mvc;
using PatitasRefugiosApi.Models;


namespace PatitasRefugiosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefugiosController : ControllerBase
    {
        // 5 refugios simulados
        private static readonly List<Refugio> Refugios = new()
        {
               new Refugio
    {
        Nombre = "Refugio Huellitas Felices",
        Direccion = "Jr. 2 de mayo 450, Cajamarca",
        Latitud = -7.155650834768485,
        Longitud =-78.51590813203295,
        Correo = "huellitas@patitas.com",
        NumCelular = "987654321",
        FotoUrl = "https://sjbuliztalqmsquunnsv.supabase.co/storage/v1/object/public/imagenes-refugio/refugio1.jpg"
    },
    new Refugio
    {
        Nombre = "Animal Rescue",
        Direccion = "Av. El Maestro 290, Cajamarca",
        Latitud = -7.160028648199608,
        Longitud = -78.51222845431963,
        Correo = "sur@patitas.com",
        NumCelular = "956123456",
        FotoUrl = "https://sjbuliztalqmsquunnsv.supabase.co/storage/v1/object/public/imagenes-refugio/refugio2.jpg"
    },
    new Refugio
    {
        Nombre = "Refugio Esperanza Animal",
        Direccion = "Av. Mario Urteaga 351, Cajamarca",
        Latitud = -7.156499734891676,
        Longitud = -78.51293435567904,
        Correo = "esperanza@patitas.com",
        NumCelular = "999888777",
        FotoUrl = "https://sjbuliztalqmsquunnsv.supabase.co/storage/v1/object/public/imagenes-refugio/refugio3.jpg"
    },
    new Refugio
    {
        Nombre = "Hogar de Colitas",
        Direccion = "Jr. Amazonas 710, Cajamarca",
        Latitud = -7.15664771858956,
        Longitud = -78.51624514763006,
        Correo = "colitas@patitas.com",
        NumCelular = "944555666",
        FotoUrl = "https://sjbuliztalqmsquunnsv.supabase.co/storage/v1/object/public/imagenes-refugio/refugio5.jpg"
    },
    new Refugio
    {
        Nombre = "Refugio Amigos de las Patas",
        Direccion = "Jr. Del Comercio 644, Cajamarca",
        Latitud = -7.164459470532843,
        Longitud = -78.51665643629933,
        Correo = "amigos@patitas.com",
        NumCelular = "987111222",
        FotoUrl = "https://sjbuliztalqmsquunnsv.supabase.co/storage/v1/object/public/imagenes-refugio/refugio4.jpg"
    }
        };

        // GET: api/refugios
        [HttpGet]
        public ActionResult<List<Refugio>> GetRefugios()
        {
            return Ok(Refugios);
        }
    }
}