using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public class MenuRepository : IMenuRepository
    {
      //instancia
      private readonly AppContext _context;

        //constructor
        public MenuRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IMenuRepository.AdicionaMenu(Menu menu){
           _context.Menus.Add(menu);
           return _context.SaveChanges();
       }       

        bool IMenuRepository.Add(Menu menu){
            _context.Menus.Add(menu);
            return (_context.SaveChanges() > 0 ? true : false);            
        }

        Menu IMenuRepository.Buscar(int id){
            return _context.Menus.Find(id);
        }

        IEnumerable<Menu> IMenuRepository.GetAll(){
            return _context.Menus;
        }

        //  IEnumerable<Menu> IMenuRepository.Buscador(){
        //     return_context,Menus;
        // }
        // IEnumerable<Menu> IMenuRepository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        IEnumerable<Menu> IMenuRepository.ObtenerMenu(){
            return _context.Menus;
        }
       
        IEnumerable<Menu> IMenuRepository.FindByName(string name){
            return _context.Menus.Where(p => p.descripcion.Contains(name) );
        }

        // IEnumerable<Asignacion> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Asignaciones.Where(p => p.persona.Contains(value));
        // }

        int IMenuRepository.Update(Menu menu){
            _context.Menus.Update(menu);
            return _context.SaveChanges();
        }

        int IMenuRepository.Delete(Menu menu){
            _context.Menus.Remove(menu);
            return _context.SaveChanges();
        }

        // IEnumerable<Menu> IMenuRepository.ObtenerTodosMenu(string value){
        //     return _context.Menus;
        // }

        List<Menu> IMenuRepository.ObtenerListadoNombre(string descrip){
            return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        }

        // IEnumerable<Asignacion> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Asignaciones.Where( p => p.persona.Contains(busqueda));
        // }

        // int IAsigancionRepository.ActualizarAsignacion(Asignacion asignacion){
        //     _context.Asignaciones.Update(asignacion);
        //     return _context.SaveChanges();
        // }

        // int IAsigancionRepository.EliminarAsignacion(Asignacion asignacion){
        //     _context.Asignaciones.Remove(asignacion);
        //     return _context.SaveChanges();
        // }
       
    }
   
}
