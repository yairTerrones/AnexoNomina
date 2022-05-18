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
    public partial class DetallesPrestaciones : Form
    {
        private LogicaNegocio _LogicaNegocio;
        private Prestacion _prestacion;
        public DetallesPrestaciones()
        {
            InitializeComponent();
            _LogicaNegocio = new LogicaNegocio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SavePrestacion();
            this.Close();
            ((Prestaciones)this.Owner).PopulateContacts();
        }

        #region Private Methods
        private void SavePrestacion()
        {
            Prestacion prestacion = new Prestacion();
            prestacion.Concepto = textBoxConcepto.Text;
            prestacion.Puesto = textBoxPuesto.Text;
            prestacion.Total = textBoxTotal.Text;

            prestacion.Id = _prestacion != null ? _prestacion.Id : 0;

           _LogicaNegocio.SavePrestacion(prestacion);
        }

        private void ClearForm()
        {
            textBoxConcepto.Text = string.Empty;
            textBoxPuesto.Text = string.Empty;
            textBoxTotal.Text = string.Empty;            
        }
        #endregion
        #region Public Methods
        public void LoadPrestacion(Prestacion prestacion)
        {
            _prestacion = prestacion;
            if (prestacion != null)
            {
                ClearForm();

                textBoxConcepto.Text = prestacion.Concepto;
                textBoxPuesto.Text = prestacion.Puesto;
                textBoxTotal.Text = prestacion.Total;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
