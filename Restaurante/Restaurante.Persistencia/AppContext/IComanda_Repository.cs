using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IComanda_Repository
    {       
        int AdicionaComanda(Comanda comanda);
        bool Add(Comanda comanda);
        Comanda Buscar(int id);
        IEnumerable<Comanda> GetAll();
        List<Comanda> ObtenerComanda();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
       // int Update(Comanda comanda);
        int Delete(Comanda comanda);
        IEnumerable<Comanda> ObtenerTodasComanda();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Comanda comanda);
        int Eliminar(Comanda comanda);
      
    } 
   
}
