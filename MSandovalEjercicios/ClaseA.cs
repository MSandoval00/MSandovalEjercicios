using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MSandovalEjercicios.ClaseA;

namespace MSandovalEjercicios
{

    public class ClaseA:ClaseB, IClaseA
    {
        public string MetodoA()
        {
            return "Hola clase: B  método: A";
        }
        public string MetodoC()
        {
            return "Hola clase: A método: A";
        }
    }
}
