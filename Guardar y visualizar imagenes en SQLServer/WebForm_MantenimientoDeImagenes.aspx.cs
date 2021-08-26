using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace Guardar_y_visualizar_imagenes_en_SQLServer
{
    public partial class WebForm_MantenimientoDeImagenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar la imagen en la base de datos SQL Server
                SqlConnection oSqlConnection = new Conexion_SQLServer().conectar();
                string query = "Insert Into tbl_contents(content) Values(@content)";
                SqlCommand oSqlCommand = new SqlCommand(query, oSqlConnection);
                oSqlCommand.Parameters.Add("@content", SqlDbType.VarBinary).Value = fuImagen.FileBytes;
                oSqlCommand.ExecuteNonQuery();
                // Mostrar la imagen de la base de datos SQL Server en la página
                lblMensajeOk.Text = "Se ha guardado la imagen correctamente.";
                lblMensajeError.Text = "";
                ListarRegistros();
            }
            catch (Exception ex)
            {
                lblMensajeOk.Text = "";
                lblMensajeError.Text = ex.Message;
            }
        }
        private void ListarRegistros()
        {
            SqlConnection oSqlConnection = new Conexion_SQLServer().conectar();
            string query = "Select * From tbl_contents;";
            SqlCommand oSqlCommand = new SqlCommand(query, oSqlConnection);
            SqlDataReader sqlDataReader = oSqlCommand.ExecuteReader();
            List<ImagenesBE> lista = new List<ImagenesBE>();
            while (sqlDataReader.Read())
            {
                ImagenesBE registro = new ImagenesBE();
                registro.ID = (Int32)sqlDataReader["ID"];
                registro.visorImagen = "Preview.aspx?id=" + registro.ID;
                lista.Add(registro);
            }
            gvListaImagenes.DataSource = lista;
            gvListaImagenes.DataBind();
        }
    }
}