using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter
    {
        public static void ImprimirReceta(Recipe receta)
        {
            Console.WriteLine(receta.DevuelveReceta()); 
        }

    }
}