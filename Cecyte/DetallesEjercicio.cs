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
    public partial class DetallesEjercicio : Form
    {
        private LogicaNegocio _LogicaNegocio;
        private Puestos _puestos;
        public DetallesEjercicio()
        {
            InitializeComponent();
            _LogicaNegocio = new LogicaNegocio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
            ((Main)this.Owner).PopulateContacts();
        }
        #region Private Methods
        private void SaveContact()
        {
            Puestos puesto = new Puestos();
            puesto.Codigo = textBoxCodigo.Text;
            puesto.Denominacion = textBoxDenominacion.Text;
            puesto.Zona = textBoxZona.Text;
            puesto.NivelSalarial = textBoxNivel.Text;
            puesto.Plazas = Convert.ToInt32(textBoxPlaza.Text);
            puesto.Horas = Convert.ToInt32(textBoxHoras.Text);
            puesto.DiferencialSueldo = Convert.ToDecimal(textBoxDiferencias.Text);
            puesto.CostoColectivo = Convert.ToDecimal(textBoxColectivo.Text);
            puesto.CostoPeriodo = Convert.ToDecimal(textBoxPeriodo.Text);
            puesto.Tipo = textBoxTipo.Text;
            puesto.Ejercicio = textBoxEjercicio.Text;

            puesto.Id = _puestos != null ? _puestos.Id : 0;

            _LogicaNegocio.SaveContact(puesto);
        }


        private void ClearForm()
        {
            textBoxCodigo.Text = string.Empty;
            textBoxDenominacion.Text = string.Empty;
            textBoxZona.Text = string.Empty;
            textBoxNivel.Text = string.Empty;
            textBoxPlaza.Text = string.Empty;
            textBoxHoras.Text = string.Empty;
            textBoxDiferencias.Text = string.Empty;
            textBoxColectivo.Text = string.Empty;
            textBoxPeriodo.Text = string.Empty;
            textBoxTipo.Text = string.Empty;
            textBoxEjercicio.Text = string.Empty;
        }
        #endregion
        #region Public Methods
        public void LoadPuesto(Puestos puestos)
        {
            _puestos = puestos;
            if (puestos != null)
            {
                ClearForm();

                textBoxCodigo.Text = puestos.Codigo;
                textBoxDenominacion.Text = puestos.Denominacion;
                textBoxZona.Text = puestos.Zona;
                textBoxNivel.Text = puestos.NivelSalarial;
                textBoxPlaza.Text = Convert.ToString(puestos.Plazas);
                textBoxHoras.Text = Convert.ToString(puestos.Horas);
                textBoxDiferencias.Text = Convert.ToString(puestos.DiferencialSueldo);
                textBoxColectivo.Text = Convert.ToString(puestos.CostoColectivo);
                textBoxPeriodo.Text = Convert.ToString(puestos.CostoPeriodo);
                textBoxTipo.Text = puestos.Tipo;
                textBoxEjercicio.Text = puestos.Ejercicio;
            }
        }
        #endregion
    }
}
