using System.ComponentModel.DataAnnotations;

namespace WebApplicationJSC.Datos.Modelo
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Fecha { get; set; }
        public int IdEstudiante { get; set; }
        public int Cantidad { get; set; }
    }
}
