using Microsoft.AspNetCore.Mvc;

namespace WebApplicationJSC.Controllers
{
    [ApiController]
    [Route("[controller]/[action")]
    public class BibliotecaController: ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }
       
        public BibliotecaController()
        {
            //Constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            //Funcion
            return "Ya tienes libro";
        }
        public string ObtenerAutor()
        {
            return "Aqui esta el Autor";
        }
        public string ObtenerPrestamo()
        {
            return "El prestamo fue obtenido correctamente";
        }
        public string ObtenerEstudiante()
        {
            return "El estudiante fue obtenido correctamente";
        }

        [HttpPost]
        public string AgregarLibro()
        {
            return "Ya tienes libro";
        }
        public string AgregarAutor()
        {
            return "Ya tienes Autor";
        }
        public string AgregarPrestamo()
        {
            return "El prestamo fue añadido";
        }
        public string AgregarEstudiante()
        {
            return "El estudiante fue añadido";
        }

        [HttpPut]
        public string ActualizarLibro()
        {
            return "Ya tienes libro";
        }
        public string ActualizarAutor()
        {
            return "Ya se actualizo Autor";
        }
        public string ActualizarPrestamo()
        {
            return "Prestamo actualizado";
        }
        public string ActualizarEstudiante()
        {
            return "Estudiante actualizado";
        }

        [HttpDelete]
        public string EliminarLibro()
        {
            return "Se elimino el libro";
        }
        public string EliminarAutor()
        {
            return "Ya eliminaste el Autor";
        }
        public string EliminarPrestamo()
        {
            return "El prestamo fue eliminado";
        }
        public string EliminarEstudiante()
        {
            return "El estudiante fue eliminado";
        }
    }
}
