using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace Restaurante.Persistencia{
   
    public class Deta_Fact_Repository : IDeta_Fact_Repository {
       
        private readonly AppContext _context;

    // constructor
        public Deta_Fact_Repository(AppContext context){
          _context = context;
        }          
     //Guardar
        int IDeta_Fact_Repository.AdicionaDetaFact(Deta_Fact Deta_Factu){
           _context.Deta_Facts.Add(Deta_Factu);
           return _context.SaveChanges();
       }       

        bool IDeta_Fact_Repository.Add(Deta_Fact Deta_Factu){
            _context.Deta_Facts.Add(Deta_Factu);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
         //buscar pórpor Id
        Deta_Fact IDeta_Fact_Repository.Buscar(int id){
            return _context.Deta_Facts.Find(id);
        }

        // IEnumerable<Deta_Fact_> IDeta_Fact_Repository.GetAll(){
        //     return _context.Deta_Facts;
        // }

        //  IEnumerable<Comanda> IComanda_Repository.Buscador(){
        //     return_context.Menus;
        // }
        // IEnumerable<Comanda> IComanda_Repository.Buscador(int busqueda){
        //     return _context.Menus.Where(p => p.id.Contains(busqueda) );
        // }
        List<Deta_Fact> IDeta_Fact_Repository.ObtenerDetaFact(){
            return _context.Deta_Facts.ToList();
        }
       
        // IEnumerable<Menu> IComanda_Repository.FindByName(string name){
        //     return _context.Menus.Where(p => p.descripcion.Contains(name) );
        // }

        // IEnumerable<Menu> IAsigancionRepository.FindMultipleParameter(string value){
        //     return _context.Menus.Where(p => p.persona.Contains(value));
        // }

        int IDeta_Fact_Repository.Update(Deta_Fact Deta_Factu){
            _context.Deta_Facts.Update(Deta_Factu);
            return _context.SaveChanges();
        }

        int IDeta_Fact_Repository.Delete(Deta_Fact Deta_Factu){
            _context.Deta_Facts.Remove(Deta_Factu);
            return _context.SaveChanges();
        }

        // IEnumerable<Deta_Fact> IDeta_Fact__Repository.ObtenerTodas(){
        //    return _context.Deta_Facts;
        // }

        // List<Comanda> IComanda_Repository.ObtenerListadoNombre(string descrip){
        //     return _context.Menus.Where( p => p.descripcion.Contains(descrip) ).ToList();
        // }

        // IEnumerable<Comanda> IAsigancionRepository.Buscador(string busqueda){
        //     return _context.Menus.Where( p => p.persona.Contains(busqueda));
        // }

        // int IComanda_Repository.Actualizar(Deta_Fact Deta_Factu){
        //     _context.Deta_Facts.Update(Deta_Factu);
        //     return _context.SaveChanges();

        // int IComanda_Repository.Eliminar(Deta_Fact Deta_Factu){
        //     _context.Deta_Facts.Remove(Deta_Factu);
        //     return _context.SaveChanges();
        // }
        }

    }
    