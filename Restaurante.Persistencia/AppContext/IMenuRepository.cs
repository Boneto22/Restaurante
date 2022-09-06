using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IMenuRepository
    {       
        int AdicionaMenu(Menu menu);
        bool Add(Menu menu);
        Menu Buscar(int id);
        IEnumerable<Menu> GetAll();
        // List<Asignacion> ObtenerTodo();
        IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Menu menu);
        int Delete(Menu menu);
        IEnumerable<Menu> ObtenerMenu();
        List<Menu> ObtenerListadoNombre(string descrip);
        //IEnumerable<Menu> Buscador();
       // int Actualizar<Menu>(Menu menu);
        // int EliminarAsignacion(Asignacion asignacion);
      
    } 
   
}