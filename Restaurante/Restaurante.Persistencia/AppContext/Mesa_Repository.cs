using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Mesa_Repository : IMesa_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Mesa_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IMesa_Repository.AdicionaMesa(Mesa mesa){
           _context.Mesas.Add(mesa);
           return _context.SaveChanges();
       }       

        bool IMesa_Repository.Add(Mesa mesa){
            _context.Mesas.Add(mesa);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pór Id
        Mesa IMesa_Repository.Buscar(int id){
            return _context.Mesas.Find(id);
        }

        IEnumerable<Mesa> IMesa_Repository.GetAll(){
            return _context.Mesas;
        }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Mesa> IMesa_Repository.ObtenerMesa(){
            return _context.Mesas.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IMesa_Repository.Update(Mesa mesa){
            _context.Mesas.Update(mesa);
            return _context.SaveChanges();
        }

        int IMesa_Repository.Delete(Mesa mesa){
            _context.Mesas.Remove(mesa);
            return _context.SaveChanges();
        }

        IEnumerable<Mesa> IMesa_Repository.ObtenerTodasMesa(){
           return _context.Mesas;
        }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IMesa_Repository.Actualizar(Mesa mesa){
            _context.Mesas.Update(mesa);
            return _context.SaveChanges();
        }

        int IMesa_Repository.Eliminar(Mesa mesa){
            _context.Mesas.Remove(mesa);
            return _context.SaveChanges();
        }
       
    }
   
}
