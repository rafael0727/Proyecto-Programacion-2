using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        //declaracion de nuestras variables como el contador y los objetos para los datos que le pasamos desde el usercontrol
        List<Pokem> listafinal = new List<Pokem>();
        int contador=0;
        UserControl userc = new UserControl();
        CheckBox CB = new CheckBox();
        ComboBox combo2 = new ComboBox();
        Form1 for1 = new Form1();
       
        public Form2()
        {
            InitializeComponent();
          

        }
        public Form2(List<Pokem> nuevalista, int cont, UserControl uc, CheckBox check,ComboBox combof2,Form1 formula1)
        {
            InitializeComponent();

            //asignacion de las nuevas variables que contendran la informacion de las variables que pasamos desde el usercontrol
            listafinal = nuevalista;
            contador = cont;
            userc = uc;
            for1 = formula1;
            CB= check;
            combo2 = combof2;

            //hacemos que los textboxt de este formulario obtengan la informacion de las listas de anteriores formularios
            textBox1.Text = listafinal[contador].nombre;
            textBox2.Text = listafinal[contador].tipo;
            textBox3.Text = listafinal[contador].numpkdx;
            textBox4.Text = listafinal[contador].codpoke.ToString();
            textBox5.Text = listafinal[contador].bhg1;

            //llamamos las funciones que cambian el lenguaje
            renombrareng();
            renombraresp();
            renombrarfr();
        }


        //funcion que renombra todo el form2 teniendo en cuenta el archivo de recursos
        public void renombrarf2()
        {
            label1.Text = Res.label1f2;
            label2.Text = Res.label2f2;
            label3.Text = Res.label3f2;
            label4.Text = Res.label4f2;
            label5.Text = Res.label5f2;
            label6.Text = Res.label6f2;
            button1.Text = Res.But1f2;
            checkBox1.Text = Res.cb1f2;
        }

        //funcion que ajusta el lenguaje a ingles teniendo en cuenta el combobox de nuestro form1
        public void renombrareng()
        {
            if (combo2.SelectedItem == "English")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("en-US");
                renombrarf2();
            }

        }


        //funcion que ajusta el lenguaje a español teniendo en cuenta el combobox de nuestro form1
        public void renombraresp()
        {
            if (combo2.SelectedItem == "Español")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("es-ES");
                renombrarf2();
            }

        }

        //funcion que ajusta el lenguaje a frances teniendo en cuenta el combobox de nuestro form1
        public void renombrarfr()
        {
            if (combo2.SelectedItem == "Francais")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("fr-FR");
                renombrarf2();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                //hacemos la actualizacion del grafico con la sigueinte linea de codigo utilizando nuestro objeto tipo form1 y llamamos la funcion que actualiza el grafico 
                for1.actualizacion(textBox1.Text, int.Parse(textBox4.Text), contador);

                //con estas lineas de codigos hacemos la actualizacion de los datos que se encuentran en cada lista en este caso de videojuegos
                listafinal[contador].nombre = textBox1.Text;
                listafinal[contador].tipo = textBox2.Text;
                listafinal[contador].numpkdx = textBox3.Text;
                listafinal[contador].codpoke = int.Parse(textBox4.Text);     
                listafinal[contador].bhg1 = textBox5.Text;

               
            }

            catch (Exception T)
            {
                MessageBox.Show("verifique que los datos se introdujeron correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CB.Checked = checkBox1.Checked;
            
            userc.Controls["label1"].Text = textBox1.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
