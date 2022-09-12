using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Persistencia
{
    public class AsignacionRepository : IAsignacionRepository{
        //instancia
      private readonly AppContext _context;
        
        //constructor
        public AsignacionRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IAsignacionRepository.AdicionaAsignacion(Asignacion asignacion){
           _context.Asignaciones.Add(asignacion);
           return _context.SaveChanges();
       }       

        bool IAsignacionRepository.Add(Asignacion asignacion){
            _context.Asignaciones.Add(asignacion);
            return (_context.SaveChanges() > 0 ? true : false);            
        }

        Asignacion IAsignacionRepository.Buscar(int id){
            return _context.Asignaciones.Find(id);
        }

        IEnumerable<Asignacion> IAsignacionRepository.GetAll(){
            return _context.Asignaciones;
        }

        List<Asignacion> IAsignacionRepository.ObtenerTodo(){
            return _context.Asignaciones.ToList();
        }

        // IEnumerable<Asignacion> IAsignacionRepository.FindByName(string name){
        //     return _context.Asignaciones.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Asignacion> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Asignaciones.Where(p => p.Asignacion.Contains(value));
        // }

        int IAsignacionRepository.Update(Asignacion asignacion){
            _context.Asignaciones.Update(asignacion);
            return _context.SaveChanges();
        }

        int IAsignacionRepository.Delete(Asignacion asignacion){
            _context.Asignaciones.Remove(asignacion);
            return _context.SaveChanges();
        }

        IEnumerable<Asignacion> IAsignacionRepository.ObtenerTodosAsignacion(){
            return _context.Asignaciones;
        }

        // List<Asignacion> IAsignacionRepository.ObtenerAsignacionPorNombre(string nombre){
        //     return _context.Asignaciones.Where( p => p.descripcion.Contains(nombre) ).ToList();
        // }

        // IEnumerable<Asignacion> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Asignaciones.Where( p => p.persona.Contains(busqueda));
        // }

        int IAsignacionRepository.ActualizarAsignacion(Asignacion asignacion){
            _context.Asignaciones.Update(asignacion);
            return _context.SaveChanges();
        }

        int IAsignacionRepository.EliminarAsignacion(Asignacion asignacion){
            _context.Asignaciones.Remove(asignacion);
            return _context.SaveChanges();
        }
       
    }
   
}
