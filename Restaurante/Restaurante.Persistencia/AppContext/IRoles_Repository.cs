using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IRoles_Repository
    {       
        int AdicionaRol(Rol rol);
        bool Add(Rol rol);
        Rol Buscar(int id);
        IEnumerable<Rol> GetAll();
        List<Rol> ObtenerRol();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Rol rol);
        int Delete(Rol rol);
        IEnumerable<Rol> ObtenerTodosRol();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Rol rol);
        int Eliminar(Rol rol);
      
    } 
   
}
