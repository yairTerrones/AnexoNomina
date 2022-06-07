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
using System.Data.SqlClient;//
using System.Globalization;

namespace Cecyte
{
    public partial class Nomina : Form
    {
        string oDBCadConexion;
        OleDbConnection oDBConnection;
        OleDbCommand oDBCommand;
        OleDbDataAdapter oDBAdapter;
        DataSet dsDatos;
        SqlCommand sqlcomand;
        SqlConnection sqlConnection;

        public Nomina()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
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

        //Metodo para Ingresar los datos a la DB
        private void button2_Click(object sender, EventArgs e)
        {
            this.insertaDatagridExcel();
        }

        //Metodo para importar el archivo de excel
        public DataView importaArchivoExcel(string unArchivoExcel)
        {
            try
            {
                if (!string.IsNullOrEmpty(unArchivoExcel))
                {
                    oDBCadConexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\"", unArchivoExcel);
                    oDBConnection = new OleDbConnection(oDBCadConexion);
                    oDBConnection.Open();

                    oDBCommand = new OleDbCommand("Select * from  [Q 01$]", oDBConnection);
                    oDBAdapter = new OleDbDataAdapter();
                    oDBAdapter.SelectCommand = oDBCommand;

                    dsDatos = new DataSet();
                    oDBAdapter.Fill(dsDatos);
                    oDBConnection.Close();
                    btnAgregar.Enabled = true;

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

        /**
         * Metodo para insertar los valores del archivo de excel en la base de datos,
         * obteniendo la informacion del datagridview.
         * 
         * Consideraciones para el archivo de EXCEL:
         * 1.- Eliminar las filas 1, 2, 4 y 5.
         * 2.- Eliminar las columnas ET, EU, EV Y EW, PERO REVISANOD QUE NO TENGA FORMULAS, SI LAS TIENE,
         *     dañara los datos de las columnas anteriores.
        */
        public void insertaDatagridExcel()
        {
            string queryNomina, cadenaNomina;
            sqlConnection = new SqlConnection("Data Source=DESKTOP-7Q2OEQG;Initial Catalog=CECYTE;Integrated Security=True;Password=Sapb1234;User ID=sa");

            try
            {
                if (dsDatos.Tables[0].Rows.Count > 0)
                {
                    sqlConnection.Open();
                    foreach (DataRow dr in dsDatos.Tables[0].Rows)
                    {
                        if (!string.IsNullOrEmpty(dr.ItemArray[0].ToString()) && !string.IsNullOrEmpty(dr.ItemArray[8].ToString()))
                        {
                            DateTime fechaFinal = DateTime.ParseExact(dr.ItemArray[8].ToString(), "dd/MMM/yyyy", CultureInfo.CreateSpecificCulture("es-US"));

                            if (fechaFinal != null)//Si se convierte correctamente la fecha
                            {
                                //Console.WriteLine(string.Join("--", dr.ItemArray));
                                //Console.OpenStandardOutput();

                                cadenaNomina = "\'" + string.Join("','", dr.ItemArray) + "\'";
                                cadenaNomina = cadenaNomina.Replace(dr.ItemArray[8].ToString(), fechaFinal.ToString("yyyy-MM-dd"));
                                //cadenaNomina = cadenaNomina + comboBoxNomina.SelectedValue.ToString();

                                queryNomina = "INSERT INTO Nomina VALUES (" + cadenaNomina + ")";
                                sqlcomand = new SqlCommand(queryNomina, sqlConnection);
                                sqlcomand.CommandType = CommandType.Text;

                                sqlcomand.ExecuteNonQuery();
                            }
                            else
                                MessageBox.Show("No se pudo convertir correctamente la fecha");
                        }
                    }
                    sqlConnection.Close();
                    MessageBox.Show("Archivo de Excel ingresado correctamente! \n", "Archivo excel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha importado ningun archivo de Excel. \n", " Error ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al insertar los datos en la base de datos. \n" + ex.ToString(), " Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteNomina reporte = new ReporteNomina();
            reporte.Show();
        }
    }
}




//En el foreach del metodo insertaDatagridExcel
//string valor = dr["NombreColumna"].ToString();
//string valor2 = dr[0].ToString();

//dr.ItemArray.Contains(string.Empty) //Cadena vacia

//date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);