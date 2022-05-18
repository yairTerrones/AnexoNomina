using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Cecyte
{
    public partial class Prestaciones : Form
    {
        private AccesoDatos _AccesoDatos;
        private LogicaNegocio _LogicaNegocio;
        private SqlConnection conn = new SqlConnection("Password=Sapb1234;Persist Security Info=True;User ID=sa;Initial Catalog=CECYTE;Data Source=DESKTOP-71BHR8U");
        public Prestaciones()
        {
            InitializeComponent();
            _LogicaNegocio = new LogicaNegocio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }

        #region Private Methods
        private void OpenContactDetailsDialog()
        {
            DetallesPrestaciones ObjDetallesP = new DetallesPrestaciones();
            ObjDetallesP.ShowDialog(this);
        }
        private void DeletePrestacion(int id)
        {
            _LogicaNegocio.DeletePrestacion(id);
        }
        public void PopulateContacts(string searchText = null)
        {
            List<Prestacion> prestacion = _LogicaNegocio.GetPrestacion(searchText);
            GridPrestaciones.DataSource = prestacion;
        }
        #endregion

        private void Prestaciones_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateContacts(textBuscarP.Text);
            textBuscarP.Text = string.Empty;
        }

        private void GridPrestaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridPrestaciones.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                DetallesPrestaciones detallesPrestacion = new DetallesPrestaciones();
                detallesPrestacion.LoadPrestacion(new Prestacion
                {
                    Id = int.Parse(GridPrestaciones.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Concepto = GridPrestaciones.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Puesto = GridPrestaciones.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Total = GridPrestaciones.Rows[e.RowIndex].Cells[3].Value.ToString(),                    
                });
                detallesPrestacion.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                DeletePrestacion(int.Parse(GridPrestaciones.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContacts();
            }
        }
    }
}
