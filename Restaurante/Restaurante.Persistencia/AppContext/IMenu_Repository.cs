using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IMenu_Repository
    {       
        int AdicionaMenu(Menu menu);
        bool Add(Menu menu);
        Menu Buscar(int id);
        IEnumerable<Menu> GetAll();
        List<Menu> ObtenerMenu();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Menu menu);
        int Delete(Menu menu);
        IEnumerable<Menu> ObtenerTodosMenu();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Menu menu);
        int Eliminar(Menu menu);
      
    } 
   
}
