using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Ahorcado : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        char[] PalabrasAdivinadas; int Oportunidades; int sas;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[,] Palabras;
        
        public string opcion;


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            datos d = new datos();
            d.Show();
        }

        private void Ahorcado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            panel1.Show();

            picAhorcadoFeliz.Hide();
            picAhorcadoTrizte.Hide();

            button1.ForeColor = Color.Red;
            button1.Text = "JUEGO CORRIENDO";
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.Enabled = false;

            lblMensaje.Show();
            label1.Text = "8";
            label1.Show();
        }

        public Ahorcado()
        {
            InitializeComponent();

        }


        public void IniciarJuego()
        {

            
            //valores iniciales del juego
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
           
            //lblMensaje.Visible=false;
            Oportunidades = 0; //fallo
            sas = 8;
            //btnIniciarJuego.Image=Properties.Resources." ";


            Palabras = new string[,]{ 
                { "Y si perezco, que perezca.","Ester" },
                { "¿Hasta cuándo claudicaréis vosotros entre dos pensamientos?","Elias" },
                { "Muera yo la muerte de los rectos.","Balaam" },
                { "Sol, detente en Gabaón; Y tú, luna, en el valle de Ajalón.","Josue" },
                { "¿Recibiremos de Dios el bien, y el mal no lo recibiremos?","Job" },
                { "Han visto mis ojos al Rey, Jehová de los ejércitos.","Isaias" },
                { "Vosotros resistís siempre al Espíritu Santo; como vuestros padres, así también vosotros.","Esteban"},
                { "Si crees de todo corazón, bien puedes.","Felipe"},
                { "A quienes entregué a Satanás para que aprendan a no blasfemar.","Pablo"},
                { "Tu pueblo será mi pueblo, y tu Dios mi Dios.","Rut"},
                { "Pues no es difícil para Jehová salvar con muchos o con pocos.","Jonatán"},
                { "Me habéis turbado con hacerme abominable a los moradores de esta tierra.","Jacob"},
                {"El viento sopla de donde quiere, y oyes su sonido.","Jesus" },
                {"María, no temas, porque has hallado gracia delante de Dios.","Gabriel" },
                {"Y mi espíritu se regocija en Dios mi Salvador.","Maria" },
                {"Ya que así habéis hecho, juro que me vengaré de vosotros, y después desistiré."," Sanson" },
                {"Si yo soy varón de Dios, descienda fuego del cielo, y consúmate con tus cincuenta.","Elias" },
                {"Yo soy el Alfa y la Omega, el principio y el fin, el primero y el último.","Jesus" }

            }; //Palabras a adivinar


            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ".ToCharArray();

            //PALABRA ALEATORIA= ADIVINAR
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, (Palabras.Length/2));
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada, 1].ToUpper().ToCharArray();
            lblTexto.Text= Palabras[IndicePalabraSeleccionada, 0].ToUpper().ToString();
            PalabrasAdivinadas = PalabraSeleccionada;

            // CICLO QUE CARGA EL ALFABETO EN UN FLOLAYOUT ---->Fichas de juego
            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 65;
                btnLetra.Height = 45;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);
            }
            flPalabras.Controls.Clear();

            // ciclo ue agrega la palabra en un flolayout (palabra a adivinar)

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
               Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Text = "-";
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Green;
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                //Letra.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.acertijo));
                flPalabras.Controls.Add(Letra);
            }

        }
 
            void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            //Boton presionado se desactiva
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;
            

            //Compara la letra seleccionada con las letras de la palabra
            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinadas.Length; indiceRevisar++)
            {
                if (PalabrasAdivinadas[indiceRevisar] == Char.Parse(btn.Text)) 
                {
                    //Si existe la letra actulizada la palabra agregando el valor correspondido
                    Button tbx = this.Controls.Find("Adivinado" + indiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[indiceRevisar].ToString();
                    PalabrasAdivinadas[indiceRevisar] = '-';
                    encontrado = true;
                    picAhorcadoFeliz.Show();
                    picAhorcadoTrizte.Hide();


                }

            }

            //Verifica si todas las letras de la palbra estan destapadas

            bool Ganaste = true;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                //Si el usuario tiene letras pendientes por destapar se cambia el estatus
                if (PalabrasAdivinadas[indiceAnalizadorGanador] != '-')
                {
                    Ganaste = false;

                }
            }

            // Si el estatus de la variable no cambia uiere decir ue el usuario gano 
            if (Ganaste)
            {
                Ganador gn = new Ganador();
                gn.ShowDialog();
                //reiniciar el juego ------------------

                flFichasDeJuego.Enabled = false;
                button1.ForeColor = Color.LimeGreen;
                button1.FlatAppearance.BorderColor = Color.LimeGreen;
                button1.Text = "--->INICIAR JUEGO<---";
                button1.Enabled = true;
            }
            //Si no se encuentra ninguna letra de la palabra
            if (!encontrado)
            {
              

                Oportunidades = Oportunidades + 1;
                
                sas = sas - 1;
                picAhorcadoFeliz.Hide();
                picAhorcadoTrizte.Show();
                
                label1.Text = sas.ToString();
                label1.Refresh();
                //puedo poner un label para la puntuacion

                // Si las oportunidades terminaron(mostrar la palabra)
                if (Oportunidades==8)

                {
                    lblMensaje.Visible = true;
                    for (int indiceValorLetra = 0; indiceValorLetra < PalabraSeleccionada.Length; indiceValorLetra++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + indiceValorLetra, true).FirstOrDefault() as Button;
                         btnLetra.Text = btnLetra.Tag.ToString();
                        btnLetra.BackColor = Color.Red;
                        btnLetra.ForeColor = Color.Blue;

                        

                        //Boton Iniciar Juego
                        button1.ForeColor = Color.LimeGreen;
                        button1.FlatAppearance.BorderColor = Color.LimeGreen;
                        button1.Text = "INICIAR JUEGO";
                        button1.Enabled = true;



                    }
                    flFichasDeJuego.Enabled = false;
                    MessageBox.Show("¡SUERTE PARA LA PROXIMA!");
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            picAhorcadoFeliz.Hide();
            picAhorcadoTrizte.Hide();
            label1.Hide();
            lblMensaje.Hide();
            panel1.Hide();
        }




    }

}
