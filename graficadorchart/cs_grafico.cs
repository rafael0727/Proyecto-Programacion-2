using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficadorchart
{
    public class cs_grafico
    {
        Graficador ucgrafi = new Graficador();

        public void ingresarvalores(string nombre,int canti)
        {
            //llamamos la funcion de nuestro usercontrol del grafico para que se le ingresen los datos
            ucgrafi.ingresardatos(nombre,canti);
                
        }
        public void actualizargraf(string nomac2,int punt2,int pos2)
        {
            //llamamos la funcion de nuestro usercontrol del grafico para que actualizen los datos
            ucgrafi.actualizargraf(nomac2,punt2,pos2);
            
        }


    }

}
