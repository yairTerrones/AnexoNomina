using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cecyte
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenAnexoDialog();
        }
        private void btnPrestaciones_Click(object sender, EventArgs e)
        {
            OpenPrestacionesDialog();
        }
        private void OpenAnexoDialog()
        {
            Main ObjMain = new Main();
            ObjMain.ShowDialog(this);
        }
        private void OpenPrestacionesDialog()
        {
            Prestaciones ObjPrestaciones = new Prestaciones();
            ObjPrestaciones.ShowDialog(this);
        }
    }
}
