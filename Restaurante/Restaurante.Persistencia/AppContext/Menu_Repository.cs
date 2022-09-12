using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Menu_Repository : IMenu_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Menu_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IMenu_Repository.AdicionaMenu(Menu menu){
           _context.Menus.Add(menu);
           return _context.SaveChanges();
       }       

        bool IMenu_Repository.Add(Menu menu){
            _context.Menus.Add(menu);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Menu IMenu_Repository.Buscar(int id){
            return _context.Menus.Find(id);
        }

        IEnumerable<Menu> IMenu_Repository.GetAll(){
            return _context.Menus;
        }

        //  IEnumerable<Menu> IMenu_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Menu> IMenu_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Menu> IMenu_Repository.ObtenerMenu(){
            return _context.Menus.ToList();
        }
       
        // IEnumerable<Menu> IMenu_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IMenu_Repository.Update(Menu menu){
            _context.Menus.Update(menu);
            return _context.SaveChanges();
        }

        int IMenu_Repository.Delete(Menu menu){
            _context.Menus.Remove(menu);
            return _context.SaveChanges();
        }

        IEnumerable<Menu> IMenu_Repository.ObtenerTodosMenu(){
           return _context.Menus;
        }

        // List<Menu> IMenu_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Menu> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IMenu_Repository.Actualizar(Menu menu){
            _context.Menus.Update(menu);
            return _context.SaveChanges();
        }

        int IMenu_Repository.Eliminar(Menu menu){
            _context.Menus.Remove(menu);
            return _context.SaveChanges();
        }
       
    }
   
}
