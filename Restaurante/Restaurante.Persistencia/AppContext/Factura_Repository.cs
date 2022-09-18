using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Factura_Repository : IFactura_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Factura_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IFactura_Repository.AdicionaFactura(Factura factura){
           _context.Facturas.Add(factura);
           return _context.SaveChanges();
       }       

        bool IFactura_Repository.Add(Factura factura){
            _context.Facturas.Add(factura);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pór Id
        Factura IFactura_Repository.Buscar(int id){
            return _context.Facturas.Find(id);
        }

        IEnumerable<Factura> IFactura_Repository.GetAll(){
            return _context.Facturas;
        }

        //  IEnumerable<Factura> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Factura> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Factura> IFactura_Repository.ObtenerFactura(){
            return _context.Facturas.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IFactura_Repository.Update(Factura factura){
            _context.Facturas.Update(factura);
            return _context.SaveChanges();
        }

        int IFactura_Repository.Delete(Factura factura){
            _context.Facturas.Remove(factura);
            return _context.SaveChanges();
        }

        IEnumerable<Factura> IFactura_Repository.ObtenerTodasFactura(){
           return _context.Facturas;
        }

        // List<Factura> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Factura> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IFactura_Repository.Actualizar(Factura factura){
            _context.Facturas.Update(factura);
            return _context.SaveChanges();
        }

        int IFactura_Repository.Eliminar(Factura factura){
            _context.Facturas.Remove(factura);
            return _context.SaveChanges();
        }
       
    }
   
}
