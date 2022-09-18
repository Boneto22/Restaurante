using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface IDetal_Asignacion_Repository
    {       
        int AdicionaDetaAsig(Detal_Asignacion detal_asignacion);
        bool Add(Detal_Asignacion detal_asignacion);
        Detal_Asignacion Buscar(int id);
        IEnumerable<Detal_Asignacion> GetAll();
        List<Detal_Asignacion> ObtenerDetaAsig();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Detal_Asignacion detal_asignacion);
        int Delete(Detal_Asignacion detal_asigancion);
        IEnumerable<Detal_Asignacion> ObtenerTodas();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(Detal_Asignacion detal_asignacion);
        int Eliminar(Detal_Asignacion detal_asignacion);
      
    } 
   
}
