using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;


namespace Cecyte
{
    public class AccesoDatos
    {
        private SqlConnection conn = new SqlConnection("Password=Sapb1234;Persist Security Info=True;User ID=sa;Initial Catalog=CECYTE;Data Source=DESKTOP-71BHR8U");

        public void InsertContact(Puestos puestos)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO [dbo].[Anexo]
           ([Codigo]
           ,[Denominacion]
           ,[Zona]
           ,[NivelSalarial]
           ,[Plazas]
           ,[Horas]
           ,[DiferencialSueldo]
           ,[CostoColectivo]
           ,[CostoPeriodo]
           ,[Tipo]
           ,[Ejercicio]) VALUES
           (@codigo
           ,@Denominacion
           ,@Zona
           ,@NivelSalarial
           ,@Plazas
           ,@Horas
           ,@DiferencialSueldo
           ,@CostoColectivo
           ,@CostoPeriodo
           ,@Tipo
           ,@Ejercicio)";

                SqlParameter codigo = new SqlParameter();
                codigo.ParameterName = "@codigo";
                codigo.Value = puestos.Codigo;
                codigo.DbType = System.Data.DbType.String;

                SqlParameter Denominacion = new SqlParameter("@Denominacion", puestos.Denominacion);
                SqlParameter zona = new SqlParameter("@Zona", puestos.Zona);
                SqlParameter nivel = new SqlParameter("@NivelSalarial", puestos.NivelSalarial);
                SqlParameter plazas = new SqlParameter("@Plazas", puestos.Plazas);
                SqlParameter horas = new SqlParameter("@Horas", puestos.Horas);
                SqlParameter diferencial = new SqlParameter("@DiferencialSueldo", puestos.DiferencialSueldo);
                SqlParameter colectivo = new SqlParameter("@CostoColectivo", puestos.CostoColectivo);
                SqlParameter periodo = new SqlParameter("@CostoPeriodo", puestos.CostoPeriodo);
                SqlParameter tipo = new SqlParameter("@Tipo", puestos.Tipo);
                SqlParameter ejercicio = new SqlParameter("@Ejercicio", puestos.Ejercicio);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(codigo);
                command.Parameters.Add(Denominacion);
                command.Parameters.Add(zona);
                command.Parameters.Add(nivel);
                command.Parameters.Add(plazas);
                command.Parameters.Add(horas);
                command.Parameters.Add(diferencial);
                command.Parameters.Add(colectivo);
                command.Parameters.Add(periodo);
                command.Parameters.Add(tipo);
                command.Parameters.Add(ejercicio);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertPrestacion(Prestacion prestacion)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO [dbo].[Prestaciones]
           ([Concepto]
           ,[Puesto]
           ,[Total]) VALUES (@Concepto,@Puesto,@Total)";

                SqlParameter Concepto = new SqlParameter();
                Concepto.ParameterName = "@Concepto";
                Concepto.Value = prestacion.Concepto;
                Concepto.DbType = System.Data.DbType.String;

                SqlParameter Puesto = new SqlParameter("@Puesto", prestacion.Puesto);
                SqlParameter Total = new SqlParameter("@Total", prestacion.Total);               

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Concepto);
                command.Parameters.Add(Puesto);
                command.Parameters.Add(Total);                

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateContact(Puestos puesto)
        {
            try
            {
                conn.Open();
                string query = @"Update Anexo SET Codigo = @codigo,
                               Denominacion = @Denominacion,
                               Zona = @Zona,
                               NivelSalarial = @NivelSalarial,
                               Plazas = @Plazas,
                               Horas = @Horas,
                               DiferencialSueldo = @DiferencialSueldo,
                               CostoColectivo = CostoColectivo,
                               CostoPeriodo = @CostoPeriodo,
                               Tipo = @Tipo,
                               Ejercicio = @Ejercicio
                               Where Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", puesto.Id);
                SqlParameter codigo = new SqlParameter("@codigo", puesto.Codigo);
                SqlParameter Denominacion = new SqlParameter("@Denominacion", puesto.Denominacion);
                SqlParameter Zona = new SqlParameter("@Zona", puesto.Zona);
                SqlParameter NivelSalarial = new SqlParameter("@NivelSalarial", puesto.NivelSalarial);
                SqlParameter Plazas = new SqlParameter("@Plazas", puesto.Plazas);
                SqlParameter Horas = new SqlParameter("@Horas", puesto.Horas);
                SqlParameter DiferencialSueldo = new SqlParameter("@DiferencialSueldo", puesto.DiferencialSueldo);
                SqlParameter CostoColectivo = new SqlParameter("@CostoColectivo", puesto.CostoColectivo);
                SqlParameter CostoPeriodo = new SqlParameter("@CostoPeriodo", puesto.CostoPeriodo);
                SqlParameter Tipo = new SqlParameter("@Tipo", puesto.Tipo);
                SqlParameter Ejercicio = new SqlParameter("@Ejercicio", puesto.Ejercicio);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(codigo);
                command.Parameters.Add(Denominacion);
                command.Parameters.Add(Zona);
                command.Parameters.Add(NivelSalarial);
                command.Parameters.Add(Plazas);
                command.Parameters.Add(Horas);
                command.Parameters.Add(DiferencialSueldo);
                command.Parameters.Add(CostoColectivo);
                command.Parameters.Add(CostoPeriodo);
                command.Parameters.Add(Tipo);
                command.Parameters.Add(Ejercicio);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdatePrestacion(Prestacion prestacion)
        {
            try
            {
                conn.Open();
                string query = @"Update Prestaciones SET Concepto = @concepto,
                               Puesto = @puesto,
                               Total = @total
                               Where Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", prestacion.Id);
                SqlParameter concepto = new SqlParameter("@concepto", prestacion.Concepto);
                SqlParameter puesto = new SqlParameter("@puesto", prestacion.Puesto);
                SqlParameter total = new SqlParameter("@total", prestacion.Total);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(concepto);
                command.Parameters.Add(puesto);
                command.Parameters.Add(total);                

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteContact(int id)
        {
            try
            {
                conn.Open();
                string query = @"Delete from Anexo Where Id = @Id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", id));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeletePrestacion(int id)
        {
            try
            {
                conn.Open();
                string query = @"Delete from Prestaciones Where Id = @Id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", id));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void ImportarContactos()
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
        }

        public List<Puestos> GetContacts(string search = null)
        {
            List<Puestos> puestos = new List<Puestos>();
            try
            {
                conn.Open();
                string query = @"Select Id, Codigo, Denominacion, Zona, NivelSalarial, Plazas, Horas, DiferencialSueldo, CostoColectivo, CostoPeriodo, Tipo, Ejercicio from Anexo ";

                SqlCommand command = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                {
                    query += "where Denominacion LIKE @Search OR Codigo LIKE @Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    puestos.Add(new Puestos
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Codigo = reader["Codigo"].ToString(),
                        Denominacion = reader["Denominacion"].ToString(),
                        Zona = reader["Zona"].ToString(),
                        NivelSalarial = reader["NivelSalarial"].ToString(),
                        Plazas = int.Parse(reader["Plazas"].ToString()),
                        Horas = int.Parse(reader["Horas"].ToString()),
                        DiferencialSueldo = decimal.Parse(reader["DiferencialSueldo"].ToString()),
                        CostoColectivo = decimal.Parse(reader["CostoColectivo"].ToString()),
                        CostoPeriodo = decimal.Parse(reader["CostoPeriodo"].ToString()),
                        Tipo = reader["Tipo"].ToString(),
                        Ejercicio = reader["Ejercicio"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            return puestos;
        }

        public List<Prestacion> GetPrestacion(string search = null)
        {
            List<Prestacion> prestacion = new List<Prestacion>();
            try
            {
                conn.Open();
                string query = @"Select Id, Concepto, Puesto, Total from Prestaciones";

                SqlCommand command = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                {
                    query += @" where Concepto LIKE @Search OR Puesto LIKE @Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prestacion.Add(new Prestacion
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Concepto = reader["Concepto"].ToString(),
                        Puesto = reader["Puesto"].ToString(),
                        Total = reader["Total"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            return prestacion;
        }

    }
}
