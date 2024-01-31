using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSandovalEjercicios
{
    public class Problemas
    {
        public void Ejerci1()
        {
            string[] listaA = new string[] { "A", "B", "C", "D", "E", "F" };
            string[] listaB = new string[] { "B", "E", "G", "H", "I", "J" };
            List<string> listaC = new List<string>();

            listaC.AddRange(listaA);
            listaC.AddRange(listaB);
            string[] listaC2 = listaC.ToArray();
            foreach (var item in listaC2)
            {
                Console.Write(item + " ");
                Console.WriteLine("");

            }
        }
        //public void Ejercicio2()
        //{

        //}
        public void Ejercicio3()
        {

            string palabra = "";
            char[] cadenaInvertida;
            char[] oracion;
            char[] oracionInvertida;

            Console.WriteLine("Escribe la palabra para convertir a palindromo");
            palabra = Console.ReadLine().ToLower().Replace(" ", "");

            
            cadenaInvertida = palabra.ToCharArray();
            for (int i = 0; i < palabra.Length/2; i++)
            {
                char ch = cadenaInvertida[i];
                cadenaInvertida [i] = cadenaInvertida[palabra.Length-i-1];
                cadenaInvertida[palabra.Length - i - 1] = ch;
            }
            //Array.Reverse(cadenaInvertida);

            char[] palabraInvertida = cadenaInvertida; 

            char[] arregloPalabra = palabra.ToCharArray();
            for (int i = 0; i < arregloPalabra.Length; i++)
            {
                arregloPalabra[i] = palabra[i];
                oracion = arregloPalabra;
                for (int j = 0; j < palabraInvertida.Length; j++)
                {
                    palabraInvertida[j] = palabraInvertida[j];
                   oracionInvertida = palabraInvertida;
                }
                
            }
            if (palabraInvertida.SequenceEqual(arregloPalabra))
            {
                Console.WriteLine("Es Palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }

        }
        public void Ejercicio4()
        {
            int numero=0;
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0)
                {

                    pares.Add(i);
                }
                if (i%2==0)
                {
                    impares.Add(i);
                } 
            }
            Console.Write("Lista de numero impares son: ");
            foreach (var itemPares in pares)
            {
                Console.Write(" " + itemPares + " ");
            }
            Console.WriteLine("\n");
            Console.Write("Lista de numero pares son: ");
            foreach (var itemImpares in impares)
            {
                Console.Write(" " + itemImpares + " ");
            }
            
        }
        public void Ejercicio5()
        {
            int numeroProducto=0;
            decimal precioProducto = 0;
            List<object> ListaPrecio = new List<object>();
            

            Console.WriteLine("¿Cuántos productos quieres registrar?");
            numeroProducto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroProducto; i++)
            {
                Console.WriteLine("Ingresa el precio del producto: " + i);
                precioProducto = decimal.Parse(Console.ReadLine());
                var productos = new
                {
                    Numero = i,
                    precioProducto = precioProducto,
                };
                
                ListaPrecio.Add(productos);

                
                foreach (var itemProducto in ListaPrecio)
                {
                    dynamic resultJSON=JObject.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(itemProducto));
                    
                }

            }
            
        }

    }
}
