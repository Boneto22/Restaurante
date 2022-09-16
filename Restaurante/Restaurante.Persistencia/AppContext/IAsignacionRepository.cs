using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IAsignacionRepository
    {       
        int AdicionaAsignacion(Asignacion asignacion);
        bool Add(Asignacion asignacion);
        Asignacion Buscar(int id);
        IEnumerable<Asignacion> GetAll();
        List<Asignacion> ObtenerTodo();
        // IEnumerable<Asignacion> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Asignacion asignacion);
        int Delete(Asignacion asignacion);

        IEnumerable<Asignacion> ObtenerTodosAsignacion();
        // List<Asignacion> ObtenerAsignacionPorNombre(string asignacion);
        // IEnumerable<Asignacion> Buscador(string busqueda);
        int ActualizarAsignacion(Asignacion asignacion);
        int EliminarAsignacion(Asignacion asignacion);
      
    } 
   
}
