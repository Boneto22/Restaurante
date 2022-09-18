using System;
using Restaurante.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public interface ILogin_Repository
    {       
        int AdicionaLogin(Login login);
        bool Add(Login login);
        Login Buscar(int id);
        IEnumerable<Login> GetAll();
        List<Login> ObtenerLogin();
        // IEnumerable<Menu> FindByName(string name);
        // IEnumerable<Asignacion> FindMultipleParameter(string value);
        int Update(Login login);
        IEnumerable<Login> ObtenerTodosLogin();
        int Delete(Login login);
        // List<Menu> ObtenerListadoNombre(string descrip);
        // IEnumerable<Menu> Buscador();
       // int Actualizar(Login login);
        
      
    } 
   
}
