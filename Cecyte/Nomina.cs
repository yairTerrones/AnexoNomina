using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Para el archivo de excel

namespace Cecyte
{
    public partial class Nomina : Form
    {
        string oDBCadConexion;
        OleDbConnection oDBConnection;
        OleDbCommand oDBCommand;
        OleDbDataAdapter oDBAdapter;
        DataSet dsDatos;

        public Nomina()
        {
            InitializeComponent();
        }

        //Metodo para importar el archivo de Excel
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog explorador = new OpenFileDialog
                {
                    Filter = "Excel | *.xls;*.xlsx;*",
                    Title = "Seleccionar archivo"
                };

                if (explorador.ShowDialog() == DialogResult.OK)
                    dgNominaExcel.DataSource = importaArchivoExcel(explorador.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Metodo para importar el archivo de excel
        public DataView importaArchivoExcel(string unNombreArchivo)
        {
            try
            {
                if (!string.IsNullOrEmpty(unNombreArchivo))
                {
                    oDBCadConexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\"", unNombreArchivo);
                    oDBConnection = new OleDbConnection(oDBCadConexion);
                    oDBConnection.Open();

                    oDBCommand = new OleDbCommand("Select * from  [Q 01$]", oDBConnection);
                    oDBAdapter = new OleDbDataAdapter();
                    oDBAdapter.SelectCommand = oDBCommand;

                    dsDatos = new DataSet();
                    oDBAdapter.Fill(dsDatos);
                    oDBConnection.Close();

                    return dsDatos.Tables[0].DefaultView;
                }
                else
                {
                    MessageBox.Show("Error al seleccionar el archivo");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el archivo");
                return null;
            }
        }

    }
}
