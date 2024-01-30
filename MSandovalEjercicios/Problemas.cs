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
                Console.Write(item+" ");
                Console.WriteLine("");
               
            }
        }
        //public void Ejercicio2()
        //{

        //}
        public void Ejercicio3()
        {
            string palabra = "";
            Console.WriteLine("Escribe la palabra para convertir a palindroma");
            palabra=Console.ReadLine();
            
            char[] cadenaInvertida=palabra.ToCharArray();
            Array.Reverse(cadenaInvertida);
            
                if (palabra==cadenaInvertida)
                {
                    Console.WriteLine("La palabra es palindromo");
                }
                else
                {
                    Console.WriteLine("No es palindromo");
                }
            
        }
       
        
    }
}
