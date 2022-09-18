using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Rol_Repository : IRoles_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Rol_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IRoles_Repository.AdicionaRol(Rol rol){
           _context.Roles.Add(rol);
           return _context.SaveChanges();
       }       

        bool IRoles_Repository.Add(Rol rol){
            _context.Roles.Add(rol);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Rol IRoles_Repository.Buscar(int id){
            return _context.Roles.Find(id);
        }

        IEnumerable<Rol> IRoles_Repository.GetAll(){
            return _context.Roles;
        }

        //  IEnumerable<Rol> IRoles_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Rol> IRoles_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Rol> IRoles_Repository.ObtenerRol(){
            return _context.Roles.ToList();
        }
       
        // IEnumerable<Menu> IRoles_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IRoles_Repository.Update(Rol rol){
            _context.Roles.Update(rol);
            return _context.SaveChanges();
        }

        int IRoles_Repository.Delete(Rol rol){
            _context.Roles.Remove(rol);
            return _context.SaveChanges();
        }

        IEnumerable<Rol> IRoles_Repository.ObtenerTodosRol(){
           return _context.Roles;
        }

        // List<Rol> IRoles_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Rol> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IRoles_Repository.Actualizar(Rol rol){
            _context.Roles.Update(rol);
            return _context.SaveChanges();
        }

        int IRoles_Repository.Eliminar(Rol rol){
            _context.Roles.Remove(rol);
            return _context.SaveChanges();
        }
       
    }
   
}
