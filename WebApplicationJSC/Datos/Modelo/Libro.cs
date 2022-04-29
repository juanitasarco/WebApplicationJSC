using System.ComponentModel.DataAnnotations;

namespace WebApplicationJSC.Datos.Modelo
{
    public class Libro
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }   
        public int NumeroPaginas { get; set; }

    }
}
