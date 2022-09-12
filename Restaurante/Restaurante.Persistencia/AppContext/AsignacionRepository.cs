using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia
{
    public class AsignacionRepository : IAsignacionRepository
    {
    // instancia
    //   private readonly AppContext _context;

    //     //constructor
    //     public AsignacionRepository(AppContext context)
    //     {
    //       _context = context;
    //     }   
    //     //Guardar
    //     int IAsignacionRepository.AdicionaAsignacion(Asignacion asignacion){
    //        _context.Asignaciones.Add(asignacion);
    //        return _context.SaveChanges();
    //    }       

    //     bool IAsigancionRepository.Add(Asigancion asignacion){
    //         _context.Asignaciones.Add(asignacion);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }

    //     Asignacion IAsignacionRepository.Buscar(int id){
    //         return _context.Asignaciones.Find(id);
    //     }

    //     IEnumerable<Asignacion> IAsigancionRepository.GetAll(){
    //         return _context.Asignaciones;
    //     }

    //     List<Asignacion> IAsigancionRepository.ObtenerTodo(){
    //         return _context.Asignaciones.ToList();
    //     }

    //     IEnumerable<Asignacion> IAsigancionRepository.FindByName(string name){
    //         return _context.Asignaciones.Where(p => p.persona.Contains(name) );
    //     }

    //     IEnumerable<Asignacion> IAsigancionRepository.FindMultipleParameter(string value){
    //         return _context.Asignaciones.Where(p => p.persona.Contains(value));
    //     }

    //     int IAsigancionRepository.Update(Asignacion asignacion){
    //         _context.Asignaciones.Update(asigancion);
    //         return _context.SaveChanges();
    //     }

    //     int IAsigancionRepository.Delete(Asignacion asignacion){
    //         _context.CompraRepuestos.Remove(asignacion);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Asignacion> IAsigancionRepository.ObtenerTodosAsignacion(){
    //         return _context.Asignaciones;
    //     }

    //     List<Asignacion> IAsigancionRepository.ObtenerAsignacionPorNombre(string nombre){
    //         return _context.Asignaciones.Where( p => p.persona.Contains(nombre) ).ToList();
    //     }

    //     IEnumerable<Asignacion> IAsigancionRepository.Buscador(string busqueda){
    //         return _context.Asignaciones.Where( p => p.persona.Contains(busqueda));
    //     }

    //     int IAsigancionRepository.ActualizarAsignacion(Asignacion asignacion){
    //         _context.Asignaciones.Update(asignacion);
    //         return _context.SaveChanges();
    //     }

    //     int IAsigancionRepository.EliminarAsignacion(Asignacion asignacion){
    //         _context.Asignaciones.Remove(asignacion);
    //         return _context.SaveChanges();
    //     }
       
    }
   
}
