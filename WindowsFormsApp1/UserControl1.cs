using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        //declaramos las variables principales y nuevos objetos para los datos que le pasamos desde el form1
        int cont=0 ;
        ComboBox combo1 = new ComboBox();
        List<Pokem> Listauserc = new List<Pokem>();
        Form1 f1 = new Form1();
        

        public UserControl1()
        {
            InitializeComponent();
            
        }

        public UserControl1(string nombrev, List<Pokem> listadev, int contador, ComboBox combo,Form1 formu1 )
        {
            InitializeComponent();

            //declaramos las nuevas variables para las variables o datos que pasamos desde el form1 

            f1 = formu1;   
            label1.Text = nombrev;
            combo1 = combo;
            Listauserc = listadev;
            cont = contador;
            int cont2 = cont + 1;
            label2.Text = cont2.ToString() ;

            //funciones para cambiar el idioma antes de añadir un usercontrol
            renombrareng();
            renombraresp();
            renombrarfr();
        }


        //funcion para renombrar el usercontrol teniendo en cuenta el archivo de recursos
        public void renombrartodo()
        {
            button1.Text = Res.But1uc;
            checkBox1.Text = Res.cb1uc;
            button2.Text = Res.But2uc;
            
        }

        //funcion que ajusta el lenguaje a ingles utilizando el combobox de nuestro form1
        public void renombrareng()
        {
            if (combo1.SelectedItem == "English")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("en-US");
                renombrartodo();
            }

        }


        //funcion que ajusta el lenguaje a español utilizando el combobox de nuestro form1
        public void renombraresp()
        {
            if (combo1.SelectedItem == "Español")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("es-ES");
                renombrartodo();
            }

        }


        //funcion que ajusta el lenguaje a frances utilizando el combobox de nuestro form1
        public void renombrarfr()
        {
            if (combo1.SelectedItem == "Francais")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("fr-FR");
                renombrartodo();
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //creamos nuestro objeto tipo fomulario y enviamos variables y objetos a nuestro form2
            Form2 miform2 = new Form2(Listauserc, cont, this, checkBox1,combo1,f1);
            //mostrar el form2
            miform2.Show();
        }


        //boton que tiene la funcion de eliminar un usercontrol creado
        public void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
