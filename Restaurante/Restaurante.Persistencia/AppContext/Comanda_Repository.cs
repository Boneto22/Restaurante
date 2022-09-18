using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Comanda_Repository : IComanda_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Comanda_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IComanda_Repository.AdicionaComanda(Comanda comanda){
           _context.Comandas.Add(comanda);
           return _context.SaveChanges();
       }       

        bool IComanda_Repository.Add(Comanda comanda){
            _context.Comandas.Add(comanda);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Comanda IComanda_Repository.Buscar(int id){
            return _context.Comandas.Find(id);
        }

        IEnumerable<Comanda> IComanda_Repository.GetAll(){
            return _context.Comandas;
        }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Comanda> IComanda_Repository.ObtenerComanda(){
            return _context.Comandas.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        // int IComanda_Repository.Update(Comanda comanda){
        //     _context.Comandas.Update(comanda);
        //     return _context.SaveChanges();
        // }

        int IComanda_Repository.Delete(Comanda comanda){
            _context.Comandas.Remove(comanda);
            return _context.SaveChanges();
        }

        IEnumerable<Comanda> IComanda_Repository.ObtenerTodasComanda(){
           return _context.Comandas;
        }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IComanda_Repository.Actualizar(Comanda comanda){
            _context.Comandas.Update(comanda);
            return _context.SaveChanges();
        }

        int IComanda_Repository.Eliminar(Comanda comanda){
            _context.Comandas.Remove(comanda);
            return _context.SaveChanges();
        }
       
    }
   
}
