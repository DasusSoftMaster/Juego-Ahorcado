using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Ganador : Form
    {
        public Ganador()
        {
            InitializeComponent();
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
