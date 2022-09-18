using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Persona_Repository : IPersona_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Persona_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IPersona_Repository.AdicionaPersona(Persona persona){
           _context.Personas.Add(persona);
           return _context.SaveChanges();
       }       

        bool IPersona_Repository.Add(Persona persona){
            _context.Personas.Add(persona);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Persona IPersona_Repository.Buscar(int id){
            return _context.Personas.Find(id);
        }

        IEnumerable<Persona> IPersona_Repository.GetAll(){
            return _context.Personas;
        }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Persona> IPersona_Repository.ObtenerPersona(){
            return _context.Personas.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IPersona_Repository.Update(Persona persona){
            _context.Personas.Update(persona);
            return _context.SaveChanges();
        }

        int IPersona_Repository.Delete(Persona persona){
            _context.Personas.Remove(persona);
            return _context.SaveChanges();
        }

        IEnumerable<Persona> IPersona_Repository.ObtenerTodasPersona(){
           return _context.Personas;
        }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        int IPersona_Repository.Actualizar(Persona persona){
            _context.Personas.Update(persona);
            return _context.SaveChanges();
        }

        int IPersona_Repository.Eliminar(Persona persona){
            _context.Personas.Remove(persona);
            return _context.SaveChanges();
        }
       
    }
   
}
