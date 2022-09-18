using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Login_Repository : ILogin_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Login_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int ILogin_Repository.AdicionaLogin(Login login){
           _context.Logins.Add(login);
           return _context.SaveChanges();
       }       

        bool ILogin_Repository.Add(Login login){
            _context.Logins.Add(login);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Login ILogin_Repository.Buscar(int id){
            return _context.Logins.Find(id);
        }

        IEnumerable<Login> ILogin_Repository.GetAll(){
            return _context.Logins;
        }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Login> ILogin_Repository.ObtenerLogin(){
            return _context.Logins.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int ILogin_Repository.Update(Login login){
            _context.Logins.Update(login);
            return _context.SaveChanges();
        }

        int ILogin_Repository.Delete(Login login){
            _context.Logins.Remove(login);
            return _context.SaveChanges();
        }

        IEnumerable<Login> ILogin_Repository.ObtenerTodosLogin(){
           return _context.Logins;
        }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        // int IComanda_Repository.Actualizar(Login login){
        //     _context.Logins.Update(login);
        //     return _context.SaveChanges();
        // }

        
        }
       
    }
   

