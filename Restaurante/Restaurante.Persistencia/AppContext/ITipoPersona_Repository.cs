using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface ITipoPersona_Repository
    {       
        int AdicionaTipoPersona(TipoPersona tipopersona);
        bool Add(TipoPersona tipopersona);
        TipoPersona Buscar(int id);
        IEnumerable<TipoPersona> GetAll();
        List<TipoPersona> ObtenerTipoPersona();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(TipoPersona tipopersona);
        int Delete(TipoPersona tipopersona);
       // IEnumerable<TipoPersona> ObtenerTodasTipoPersona();
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
        int Actualizar(TipoPersona tipopersona);
        int Eliminar(TipoPersona tipopersona);
      
    } 
   
}
