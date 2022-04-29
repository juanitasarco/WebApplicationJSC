using System.ComponentModel.DataAnnotations;

namespace WebApplicationJSC.Datos.Modelo
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Pais { get; set; }
        public string SobreNombre { get; set; }

    }
}
