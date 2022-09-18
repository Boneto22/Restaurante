using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IPersona_Repository
    {       
        int AdicionaPersona(Persona persona);
        bool Add(Persona persona);
        Persona Buscar(int id);
        IEnumerable<Persona> GetAll();
        List<Persona> ObtenerPersona();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Persona persona);
        int Delete(Persona persona);
        IEnumerable<Persona> ObtenerTodasPersona();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Persona persona);
        int Eliminar(Persona persona);
      
    } 
   
}
