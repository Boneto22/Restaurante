using System;

namespace Restaurante.Dominio{

    public class Persona{ 
        int id {get; set;}
        String documento {get; set;}
        String nombre {get; set;}
        String apellido {get; set;}
        String email {get; set;}
        String telefono {get; set;}
        TipoPersona Tipopersona {get; set;}
    
    }
}