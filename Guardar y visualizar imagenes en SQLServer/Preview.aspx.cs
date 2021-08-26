using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Guardar_y_visualizar_imagenes_en_SQLServer
{
    public partial class WebForm_Imagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection oSqlConnection = new Conexion_SQLServer().conectar();
                string query = "Select* From tbl_contents Where ID = @ID";
                SqlCommand oSqlCommand = new SqlCommand(query, oSqlConnection);
                oSqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Request.QueryString["id"];
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                if (oSqlDataReader.Read())
                {
                    byte[] imagen = (byte[])oSqlDataReader["content"];
                    //Response.ContentType = "image/JPEG";
                    Response.ContentType = "application/pdf";
                    Response.BinaryWrite(imagen);
                }
                oSqlConnection.Close();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}