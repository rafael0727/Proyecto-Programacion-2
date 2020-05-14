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
    public partial class Form1 : Form
    {
        //declaracion de las variables como contadores
        int mivalor = 0;
        int contador = -1;

        //creacion de las listas
        List<Pokem> misv = new List<Pokem>();
        List<UserControl> userc = new List<UserControl>();


        //creamos esta funcion para parsarla al form2 para realizar la actualizacion del grafico
        public void actualizacion(string nom, int punt, int posi)
        {
            uCgraficador1.actualizargraf(nom, punt, posi);
        }

        public Form1()
        {
            InitializeComponent();
            //ocultar el chart antes de añadir un usercontrol
            uCgraficador1.Visible = false;

          

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            //hacer el graficador visible una vez se añadio un usercontrol
            
            uCgraficador1.Visible = true;
            
            try {
               
                contador++;
              //crear un nuevo objeto de la lista videojuego una vez se use el boton  
                Pokem V = new Pokem();
               

            //llamando las funciones del dll para graficar el chart y establecer los nombres y puntos
            uCgraficador1.ingresardatos(textBox1.Text, int.Parse(textBox4.Text));
               
            //añadiendo datos a la lista en este caso videojuegos  
            panel1.VerticalScroll.Value = 0;
            V.nombre = textBox1.Text;
            V.tipo = textBox2.Text;
            V.numpkdx = textBox3.Text;
            V.codpoke = int.Parse(textBox4.Text);
            V.bhg1 = textBox5.Text;

                
             //pasando las variables o objetos necesarios a nuestro usercontrol   
            UserControl1 miUC = new UserControl1(textBox1.Text, misv, contador, comboBox1,this);
            misv.Add(V);
            userc.Add(miUC);
            panel1.Controls.Add(miUC) ;

            //ajustar la posicion del usercontrol
            miUC.Location = new System.Drawing.Point(15, mivalor);
            mivalor = miUC.Size.Height + mivalor;

            //funcion para limpiar las cajas de texto una vez añadido un videojuego
            limpiardatos();

            }
            catch(Exception)
            {
                MessageBox.Show("verifique que todos los datos se introdujeron correctamente");
               
            }
            
        }

        
        //funcion que limpia los datos
        private void limpiardatos()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        //funcion de renombra este formulario teniendo en cuenta los archivos de recursos
        private void renombrarf1()
        {
            label1.Text = Res.label1;
            label2.Text = Res.label2;
            label3.Text = Res.label3;
            label4.Text = Res.label4;
            label5.Text = Res.label5;
            label6.Text = Res.label6;
            label7.Text = Res.dlllabel;
            label8.Text = Res.dllresul;
            label9.Text = Res.label9;
            button1.Text = Res.But1;
            button2.Text = Res.dllbut;
            button3.Text = Res.But3;
            label10.Text = Res.labelgra;   

        } 

        //funcion para renombrar el usercontrol teniendo en cuenta los archivos de recursos
        private void renombraruc()
        {
            foreach (UserControl1 uc in userc)
            {
                uc.renombrartodo();
            }
        }
       
        //funcion para utilizar nuestra dllnumero
        private void button2_Click_1(object sender, EventArgs e)
        {
            int a = gg.CS_dll.dllprimera(textBox6.Text);
            label8.Text = "RESULTADO="+a.ToString(); 
        }


        private void button3_Click(object sender, EventArgs e)
        {

            //en este boton creamos utilizamos funciones if para ajustar el lenguaje seleccionado en el combobox1
            

            if (comboBox1.SelectedItem == "English")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("en-US");
                renombrarf1();
                renombraruc();
                uCgraficador1.renombrarenglish();

            }
            if (comboBox1.SelectedItem == "Español")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("es-ES");
                renombrarf1();
                renombraruc();
                uCgraficador1.renombrarespañol();
            }
            if (comboBox1.SelectedItem == "Francais")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("fr-FR");
                renombrarf1();
                renombraruc();
                uCgraficador1.renombrarfrancais();
            }


        }

        private void ucgraficador1_Load(object sender, EventArgs e)
        {
            
        }

        private void uCgraficador1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    }

