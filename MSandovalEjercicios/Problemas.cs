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
        public void Ejercicio2()
        {
            int numero = 0;
            int cantidad = 0;
            string numeroLetras = "";
            int totalnumero = 0;
            string[] listaPalabra = new string[] { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };

            Console.WriteLine("Ingresa un número del 0 - 99");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0 || numero > 99)
            {
                Console.WriteLine("No es un número dentro del rango de 0 - 99");
            }
            else
            {
                if (numero >= 10)
                {
                    //Dividir el numero en dos
                    while (numero>0)
                    {
                        int numeroSeparado = numero % 10;
                        numero=numero / 10;
                        numeroLetras = listaPalabra[numeroSeparado];
                        totalnumero=numeroLetras.Count();
                        
                        Console.WriteLine($"El numero:{numeroSeparado} tiene un número {numeroLetras.Count()}  ");

                         cantidad = totalnumero + cantidad;
                    }
                    
                    if (cantidad != 0)
                    {
                        Console.WriteLine($"El total de letra es: {cantidad}");
                    }
                }
                else
                {
                    numeroLetras = listaPalabra[numero];
                    Console.WriteLine($"El número : {numero} tiene un número {numeroLetras.Count()} letras  ");

                }
            }

        }
        public void Ejercicio3()
        {

            string palabra = "";
            char[] cadenaInvertida;
            char[] oracion;
            char[] oracionInvertida;

            Console.WriteLine("Escribe la palabra para convertir a palindromo");
            palabra = Console.ReadLine().ToLower().Replace(" ", "");


            cadenaInvertida = palabra.ToCharArray();
            for (int i = 0; i < palabra.Length / 2; i++)
            {
                char ch = cadenaInvertida[i];
                cadenaInvertida[i] = cadenaInvertida[palabra.Length - i - 1];
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

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {

                    pares.Add(i);
                }
                if (i % 2 == 0)
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
            int numeroProducto = 0;
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
                    Precio = precioProducto,
                };

                ListaPrecio.Add(productos);
            }
            dynamic puntoMax = ListaPrecio.OrderByDescending(p => ((dynamic)p).Precio).First();
            dynamic puntoMin = ListaPrecio.OrderBy(p => ((dynamic)p).Precio).First();
            Console.WriteLine($"El producto {puntoMax.Numero} con mayor precio es de {puntoMax.Precio} ");
            Console.WriteLine($"El producto {puntoMin.Numero} con menor precio es de {puntoMin.Precio} ");
        }

    }
}
