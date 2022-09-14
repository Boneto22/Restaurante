using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IFactura_Repository
    {       
        int AdicionaFactura(Factura factura);
        bool Add(Factura factura);
        Factura Buscar(int id);
        IEnumerable<Factura> GetAll();
        List<Factura> ObtenerFactura();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Factura factura);
        int Delete(Factura factura);
        IEnumerable<Factura> ObtenerTodasFactura();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Factura factura);
        int Eliminar(Factura factura);
      
    } 
   
}
