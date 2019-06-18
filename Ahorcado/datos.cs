using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ahorcado
{
    public partial class datos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public datos()
        {
            InitializeComponent();
        }

        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio. 
        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje. 
            else
            {
                enviarDatos();
            }
            vacio = false; // Devolvemos el valor original a nuestra variable. 
        }

        private void enviarDatos()
        {
            Ahorcado var = new Ahorcado();
            
            var.Show();
            this.Hide();
        }
        private void datos_Load(object sender, EventArgs e)
        {

        }

        private void datos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            txtF.Text = "";
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {

            validar(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
