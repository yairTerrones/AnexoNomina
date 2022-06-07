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

        //Metodo para Abrir la ventana de Nomina.
        private void btnNomina_Click(object sender, EventArgs e)
        {
            try
            {
                Nomina nomina = new Nomina();
                nomina.MdiParent = this;
                nomina.Show();
            }
            catch (Exception ex)
            {

            }
        }


//===================== Crear reportes ==================

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.MdiParent = this;
            reportes.Show();
        }

    }
}
