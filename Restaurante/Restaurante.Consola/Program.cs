using System;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Consola {
    class Program
    {
       //instancia del repositorio
      private static Persistencia.IMenuRepository menuRepository = new MenuRepository( new Restaurante.Persistencia.AppContext());
       
        public static void Main(string[] args)
        {
             
            addMenu();     
        //     FindAll(); 
        //     FindByName();
        //     Find();            
        //     Update();
        //     Delete();                 
        //     ObtenerTodosMenu();
        //     BuscarPorNombre();
        //    Buscador();
        //    Actualizar();
        //     EliminarNivelPlato();

           
        }
   
        public static void addMenu(){
            
             Console.WriteLine("Registrando el Menu...");

           var menu = new Menu{
                descripcion = "sopa de queso",
                precio = 10000
            };
            menuRepository.Add(menu);
         //   try
         //    {
            var  result = menuRepository.Add(menu);

            if(result > 0){
               Console.WriteLine("Menú insertado con exito..");
                    }else{
                        Console.WriteLine("Error" , "No se pudo insertar el Menu.");
                    }
            }catch (System.Exception e){
                Console.WriteLine("Ocurrio un error: " + e );
                throw;
            }       
        }
       

        public static void FindAll(){
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Listado de Menu");
            Console.WriteLine("-----------------------------------------------");
            
            var resultGeneral = menuRepository.GetAll();

            foreach (var resultMenu in resultGeneral)
            {
                Console.WriteLine("Id: " + resultMenu.id +", Descripción Menu: " + resultMenu.descripcion +", Precio: "+ resultMenu.precio);
            }
        }

        public static void FindByName(){

            var result = menuRepository.FindByName("zancocho");

            foreach (var resultMenu in result)
            {
                 Console.WriteLine("Id: " + resultMenu.id +", Descripción Menu: " + resultMenu.descripcion +", Precio: "+ resultMenu.precio);
            }
        }

        // //por id
        public static void Find(){

            var result = menuRepository.Buscar(1);
            Console.WriteLine( result.descripcion );
        }

        public static void Update(){

            var result = menuRepository.Buscar(1);

            if( result != null){

                result.descripcion = "Mondongo";              

                var res = menuRepository.Update(result);

                if(res > 0){
                    Console.WriteLine("Se actualizo con exito");
                }else{
                    Console.WriteLine("No fue posible actualizar");
                }
            }else{
                Console.WriteLine("No existe ese plato para actualizar");
            }

        }

        public static void Delete(){

            var result = menuRepository.Buscar(4);

            if( result != null){

                var res = menuRepository.Delete(result);

                if(res > 0){
                    Console.WriteLine("Se elimino con exito");
                }else{
                    Console.WriteLine("No fue posible eliminar");
                }
            }else{
                Console.WriteLine("No existe ese plato a eliminar");
            }

        }       

        public static void ObtenerTodosMenu(){

            var listadomenu = MenuRepository.ObtenerMenu();

            foreach (var Lista in listadomenu)
            {
                Console.WriteLine("Id: " + Lista.id + ", Descripcion: " + Lista.Descripcion + ", Precio: " + Lista.precio );
            }

        }

        public static void BuscarPorNombre(){
             
             var listadomenu = menuRepository.ObtenerListadoNombre( "sopa" );

             foreach (var R in listadomenu)
             {
                Console.WriteLine("Id: " + R.id + ", Descripcion: " + R.descripcion + ", Precio; "+ R.precio);
             }

        }

        public static void Buscador(){
             
             var listado = menuRepository.Buscador(3);

             foreach (var Menu1 in listado)
             {
                Console.WriteLine("Id: " + Menu1.id + ", Descripción: " + Menu1.descripcion );
             }

        }

        public static void Actualizar(){

            var Plato = MenuRepository.Buscar(3);

            if( Plato != null){

                Plato.descripcion = " Carne Oreada";          
               
                var result = MenuRepository.ActualizarMenu(plato);

                if( result > 0 )
                    Console.WriteLine("Se actualizo con exito, se afectaron " + result + " registros.");
                else
                    Console.WriteLine("No se logro actualizar");

            }else{
                Console.WriteLine("No existe la persona a actualizar");
            }
        }

        public static void EliminarNivelPlato(){

            var Plato = MenuRepository.Buscar(3);

            if( Plato != null){

                var result = MenuRepository.EliminarNivelPlato(Plato);

                if( result > 0 )
                    Console.WriteLine("Se elimino con exito, se afectaron " + result + " registros.");
                else
                    Console.WriteLine("No se logro eliminar");

            }else{
                Console.WriteLine("No existe la persona a eliminar");
            }
         }

   }
}
