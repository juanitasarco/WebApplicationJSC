using Microsoft.EntityFrameworkCore;
using WebApplicationJSC.Datos.Modelo;

namespace WebApplicationJSC.Datos.Servicio
{
    public class RepositorioBiblioteca: DbContext

    {
        //ctor
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options): base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        //Crear otras 3 propiedades restantes (Autor, Estudiante, Prestamo)
    }
}
