using System.ComponentModel.DataAnnotations;

namespace WebApplicationJSC.Datos.Modelo
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Grado { get; set; }
    }
}
