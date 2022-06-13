using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Cecyte
{
    public partial class Reportes : Form
    {
        DataSet dsDatos;
        SqlCommand sqlComand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;

        public Reportes()
        {
            InitializeComponent();
        }


        //==============================================================================================
        //Metodo para traer la info de la base de datos.
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbAño.SelectedItem == null || cbQuincena.SelectedItem == null)
                {
                    MessageBox.Show("Error al generar la consulta SQL: \n No se ha seleccionado año y/o quincena.", "Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(cbAño.SelectedItem.ToString()) && string.IsNullOrEmpty(cbQuincena.SelectedItem.ToString()))
                {
                    MessageBox.Show("Error al generar la consulta SQL: \n No se ha seleccionado año y/o quincena.", "Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    sqlConnection = new SqlConnection("Data Source=DESKTOP-7Q2OEQG;Initial Catalog=CECYTE;Integrated Security=True;Password=Sapb1234;User ID=sa");
                    sqlConnection.Open();

                    //sqlComand = new SqlCommand("Select * from  Nomina order by NumEmpleado", sqlConnection);//Agregar en el query el año y la quincena
                    sqlComand = new SqlCommand("exec [dbo].[CECYTE_Nomina] " + cbAño.SelectedItem.ToString() + "," + cbQuincena.SelectedItem.ToString(), sqlConnection);//Agregar en el query el año y la quincena
                    sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlComand;

                    dsDatos = new DataSet();
                    sqlDataAdapter.Fill(dsDatos);
                    sqlConnection.Close();

                    DataDetalles.DataSource = dsDatos.Tables[0].DefaultView;
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la consulta SQL: \n" + ex.Message, "Error SQL",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===============================================================================================
        //Metodo para generar el reporte en EXCEL.
        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2016 (*.xls)|*.xls";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Data.DataTable dt = this.DataGridView_A_DataSet(DataDetalles);
                    exportToExcel(dt, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para exportar el archivo EXCEL.
        public bool exportToExcel(System.Data.DataTable unDataTable, string unaRuta)
        {
            int ColumnsCount;
            object[] Header;

            try
            {
                if (unDataTable == null || unDataTable.Columns.Count == 0)
                {
                    MessageBox.Show("El Datagrid no contiene ningun tipo de informacion para exportar!");
                    return false;
                }
                else
                {
                    //Crear archivo excel
                    Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                    Excel.Workbooks.Add();
                    Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;

                    ColumnsCount = unDataTable.Columns.Count; //Numero de columnas
                    Header = new object[ColumnsCount];
                    for (int i = 0; i < ColumnsCount; i++)
                        Header[i] = unDataTable.Columns[i].ColumnName;

                    Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                    HeaderRange.Value = Header;
                    HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    HeaderRange.Font.Bold = true;

                    int RowsCount = unDataTable.Rows.Count;
                    object[,] Cells = new object[RowsCount, ColumnsCount];

                    for (int j = 0; j < RowsCount; j++)
                        for (int i = 0; i < ColumnsCount; i++)
                            Cells[j, i] = unDataTable.Rows[j][i];

                    Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                    if (!string.IsNullOrEmpty(unaRuta))
                    {
                        try
                        {
                            Worksheet.SaveAs(unaRuta);
                            Excel.Quit();
                            MessageBox.Show("Excel file saved!");
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                              + ex.Message);
                        }
                    }
                    else  // no filepath is given
                    {
                        Excel.Visible = true;
                    }


                    MessageBox.Show("Data is exported!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Metodo para crear un datatable recorriendo el datagridview
        public System.Data.DataTable DataGridView_A_DataSet(DataGridView unDataGridView)
        {
            System.Data.DataTable ExportDataTable;
            DataRow dRow;

            try
            {
                ExportDataTable = new System.Data.DataTable();

                //Recorremos las columnas
                foreach (DataGridViewColumn col in unDataGridView.Columns)
                    ExportDataTable.Columns.Add(col.Name);

                //Recorremos las filas
                foreach (DataGridViewRow row in unDataGridView.Rows)
                {
                    dRow = ExportDataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                        dRow[cell.ColumnIndex] = cell.Value;

                    ExportDataTable.Rows.Add(dRow);
                }

                return ExportDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //===============================================================================================

    }
}
