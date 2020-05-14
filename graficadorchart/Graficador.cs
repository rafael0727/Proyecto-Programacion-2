using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficadorchart
{
    public partial class Graficador : UserControl
    {
        public Graficador()
        {
            InitializeComponent();
            //utilzamos este codigo para establecer el color de nuestra barra del chart en este caso azul
            chart1.Series[0].Color = Color.Aquamarine;

        }

        //funcion que recibe los datos que se utilizaran en el grafico
        public void ingresardatos(string nombre, int num)
        {
            chart1.Series[0].Points.AddXY(nombre, num);

        }

        //funcion que actualiza los datos una vez ingresados contiene nombre,puntos y la posicion 
        public void actualizargraf(string nom, int punt, int pos)
        {

            chart1.Series[0].Points[pos].SetValueXY(nom, punt);

        }

        //este boton realiza la funcion de mostrar u ocultar la etiqueta del numero de puntos que se muestra sobre la barra
        private void button1_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].IsValueShownAsLabel)
                chart1.Series[0].IsValueShownAsLabel = false;
            else
                chart1.Series[0].IsValueShownAsLabel = true;
        }

        //funcion para cambiar el color de la barra de nuestro grafico desde un combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Verde")
            {
                chart1.Series[0].Color = Color.Aquamarine;
            }

            if (comboBox1.SelectedItem == "Azul")
            {
                chart1.Series[0].Color = Color.DeepSkyBlue;
            }
            if (comboBox1.SelectedItem == "Rojo")
            {
                chart1.Series[0].Color = Color.Red;
            }
        }

        //funcion que renombra los textos a idioma español teniendo en cuenta el archivo de recursos
        public void renombrarespañol()
        {
            button1.Text = Res.etiqueta;
            label1.Text = Res.color;
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("es-ES");
        }


        //funcion que renombra los textos a idioma ingles teniendo en cuenta el archivo de recursos
        public void renombrarenglish()
        {
            button1.Text = Res.etiqueta;
            label1.Text = Res.color;
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("en-US");
        }

        //funcion que renombra los textos a idioma frances teniendo en cuenta el archivo de recursos
        public void renombrarfrancais()
        {
            button1.Text = Res.etiqueta;
            label1.Text = Res.color;
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("fr-FR");
        }
    }
}
