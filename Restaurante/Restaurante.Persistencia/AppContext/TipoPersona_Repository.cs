using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class TipoPersona_Repository : ITipoPersona_Repository {
       
        private readonly AppContext _context;

    // constructor
        public TipoPersona_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int ITipoPersona_Repository.AdicionaTipoPersona(TipoPersona tipopersona){
           _context.TipoPersonas.Add(tipopersona);
           return _context.SaveChanges();
       }       

        bool ITipoPersona_Repository.Add(TipoPersona tipopersona){
            _context.TipoPersonas.Add(tipopersona);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        TipoPersona ITipoPersona_Repository.Buscar(int id){
            return _context.TipoPersonas.Find(id);
        }

        IEnumerable<TipoPersona> ITipoPersona_Repository.GetAll(){
            return _context.TipoPersonas;
        }

        //  IEnumerable<TipoPersona> ITipoPersona_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<TipoPersona> ITipoPersona_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<TipoPersona> ITipoPersona_Repository.ObtenerTipoPersona(){
            return _context.TipoPersonas.ToList();
        }
       
        // IEnumerable<Menu> ITipoPersona_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int ITipoPersona_Repository.Update(TipoPersona tipopersona){
            _context.TipoPersonas.Update(tipopersona);
            return _context.SaveChanges();
        }

        int ITipoPersona_Repository.Delete(TipoPersona tipopersona){
            _context.TipoPersonas.Remove(tipopersona);
            return _context.SaveChanges();
        }

        // IEnumerable<TipoPersona> ITipoPersona_Repository.ObtenerTodasTipoPersona(){
        //    return _context.TipoPersonas;
        // }

        // List<TipoPersona> ITipoPersona_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<TipoPersona> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int ITipoPersona_Repository.Actualizar(TipoPersona tipopersona){
            _context.TipoPersonas.Update(tipopersona);
            return _context.SaveChanges();
        }

        int ITipoPersona_Repository.Eliminar(TipoPersona tipopersona){
            _context.TipoPersonas.Remove(tipopersona);
            return _context.SaveChanges();
        }
       
    }
   
}
