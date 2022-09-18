using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IMesa_Repository
    {       
        int AdicionaMesa(Mesa mesa);
        bool Add(Mesa mesa);
        Mesa Buscar(int id);
        IEnumerable<Mesa> GetAll();
        List<Mesa> ObtenerMesa();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Mesa mesa);
        int Delete(Mesa mesa);
        IEnumerable<Mesa> ObtenerTodasMesa();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Mesa mesa);
        int Eliminar(Mesa mesa);
      
    } 
   
}
