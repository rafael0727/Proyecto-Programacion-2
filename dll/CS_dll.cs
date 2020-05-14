using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
    public class CS_dll
    {

        //funcion de tipo estatico que realiza la dllprimera de las cifras que contiene un numero
        public static int dllprimera(string a)
        {
            
            int better = 0;
            foreach (char c in a)
            {
                better += int.Parse(c.ToString());
            }
         
            return better;
        }

       
    }
}
