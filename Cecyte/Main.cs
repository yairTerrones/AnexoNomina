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
    public partial class Main : Form
    {
        private AccesoDatos _AccesoDatos;
        private LogicaNegocio _LogicaNegocio;
        private SqlConnection conn = new SqlConnection("Password=Sapb1234;Persist Security Info=True;User ID=sa;Initial Catalog=CECYTE;Data Source=DESKTOP-71BHR8U");
        public Main()
        {
            InitializeComponent();
            _LogicaNegocio = new LogicaNegocio();
        }        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Excel_Demo\\Anexo.xlsx;" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                OleDbConnection origen = default(OleDbConnection);
                origen = new OleDbConnection(conexion);

                OleDbCommand seleccion = default(OleDbCommand);
                seleccion = new OleDbCommand("select * From [Sheet1$]", origen);

                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                adaptador.SelectCommand = seleccion;

                DataSet ds = new DataSet();

                adaptador.Fill(ds);

                origen.Close();

                //SqlConnection conexion_destino = new SqlConnection();
                //conexion_destino.ConnectionString = "Password=Sapb1234;Persist Security Info=True;User ID=sa;Initial Catalog=CECYTE;Data Source=DESKTOP-71BHR8U";
                conn.Open();
                //conexion_destino.Open();

                SqlBulkCopy importar = default(SqlBulkCopy);
                importar = new SqlBulkCopy(conn);
                importar.DestinationTableName = "Anexo";
                importar.WriteToServer(ds.Tables[0]);
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            PopulateContacts();
        }

        #region Private Methods
        private void OpenContactDetailsDialog()
        {
            DetallesEjercicio ObjDetallesE = new DetallesEjercicio();
            ObjDetallesE.ShowDialog(this);
        }
        private void DeleteContact(int id)
        {
           _LogicaNegocio.DeleteContact(id);
        }
        public void PopulateContacts(string searchText = null)
        {
            List<Puestos> puestos = _LogicaNegocio.GetContacts(searchText);
            GridPuestos.DataSource = puestos;
        }

        #endregion

        private void GridPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridPuestos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                DetallesEjercicio detallesEjercicio = new DetallesEjercicio();
                detallesEjercicio.LoadPuesto(new Puestos
                {
                    Id = int.Parse(GridPuestos.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Codigo = GridPuestos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Denominacion = GridPuestos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Zona = GridPuestos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    NivelSalarial = GridPuestos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Plazas = int.Parse(GridPuestos.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    Horas = int.Parse(GridPuestos.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    DiferencialSueldo = decimal.Parse(GridPuestos.Rows[e.RowIndex].Cells[7].Value.ToString()),
                    CostoColectivo = decimal.Parse(GridPuestos.Rows[e.RowIndex].Cells[8].Value.ToString()),
                    CostoPeriodo = decimal.Parse(GridPuestos.Rows[e.RowIndex].Cells[9].Value.ToString()),
                    Tipo = GridPuestos.Rows[e.RowIndex].Cells[10].Value.ToString(),
                    Ejercicio = GridPuestos.Rows[e.RowIndex].Cells[11].Value.ToString(),
                });
                detallesEjercicio.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Borrar")
            {
                DeleteContact(int.Parse(GridPuestos.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContacts();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateContacts(textBuscar.Text);
            textBuscar.Text = string.Empty;
        }
    }
}
