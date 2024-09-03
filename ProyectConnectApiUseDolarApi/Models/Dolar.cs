using System.ComponentModel;

namespace ProyectConnectApiUseDolarApi.Models
{
    public class Dolar
    {
        public float Compra { get; set; }
        public float Venta { get; set; }
        public string Casa { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        [DisplayName("Fecha de Actualizacion")]
        public string FechaActualizacion { get; set; } = null!;
    }
}