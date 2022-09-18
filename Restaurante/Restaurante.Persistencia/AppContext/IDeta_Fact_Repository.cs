using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IDeta_Fact_Repository
    {       
        int AdicionaDetaFact(Deta_Fact Deta_Factu);
        bool Add(Deta_Fact Deta_Factu);
        Deta_Fact Buscar(int id);
       // IEnumerable<Deta_Fact> GetAll();
        List<Deta_Fact> ObtenerDetaFact();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Deta_Fact Deta_Factu);
        int Delete(Deta_Fact Deta_Factu);
       // IEnumerable<Deta_Fact> ObtenerTodas();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        //int Actualizar(Deta_Fact Deta_Facts);
       // int Eliminar(Deta_Fact Deta_Facts);
      
    } 
   
}
