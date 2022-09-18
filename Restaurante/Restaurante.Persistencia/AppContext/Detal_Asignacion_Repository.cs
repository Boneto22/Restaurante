using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Detal_Asignacion_Repository : IDetal_Asignacion_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Detal_Asignacion_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IDetal_Asignacion_Repository.AdicionaDetaAsig(Detal_Asignacion detal_asignacion){ 
           _context.Detal_Asignaciones.Add(detal_asignacion);
           return _context.SaveChanges();
       }       

        bool IDetal_Asignacion_Repository.Add(Detal_Asignacion detal_asignacion){
            _context.Detal_Asignaciones.Add(detal_asignacion);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Detal_Asignacion IDetal_Asignacion_Repository.Buscar(int id){
            return _context.Detal_Asignaciones.Find(id);
        }

        IEnumerable<Detal_Asignacion> IDetal_Asignacion_Repository.GetAll(){
            return _context.Detal_Asignaciones;
        }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Detal_Asignacion> IDetal_Asignacion_Repository.ObtenerDetaAsig(){
            return _context.Detal_Asignaciones.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IDetal_Asignacion_Repository.Update(Detal_Asignacion detal_asignacion){
            _context.Detal_Asignaciones.Update(detal_asignacion);
            return _context.SaveChanges();
        }

        int IDetal_Asignacion_Repository.Delete(Detal_Asignacion detal_asignacion){
            _context.Detal_Asignaciones.Remove(detal_asignacion);
            return _context.SaveChanges();
        }

        IEnumerable<Detal_Asignacion> IDetal_Asignacion_Repository.ObtenerTodas(){
           return _context.Detal_Asignaciones;
        }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IDetal_Asignacion_Repository.Actualizar(Detal_Asignacion detal_asignacion){
            _context.Detal_Asignaciones.Update(detal_asignacion);
            return _context.SaveChanges();
        }

        int IDetal_Asignacion_Repository.Eliminar(Detal_Asignacion detal_asignacion){
            _context.Detal_Asignaciones.Remove(detal_asignacion);
            return _context.SaveChanges();
        }
       
    }
   
}
