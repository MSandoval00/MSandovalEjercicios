using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSandovalEjercicios
{
    interface IClaseA
    {
        string MetodoA();
        string MetodoB();
        string MetodoC();
    }
    public class ClaseB 
    {
        public string MetodoB()
        {
            return "Hola clase: B método: B";
        }
    }
}
