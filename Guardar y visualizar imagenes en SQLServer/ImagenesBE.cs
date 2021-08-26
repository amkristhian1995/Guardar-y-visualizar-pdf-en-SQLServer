namespace Guardar_y_visualizar_imagenes_en_SQLServer
{
    public class ImagenesBE
    {
        public int ID { get; set; }
        public byte[] Imagen { get; set; }
        public string visorImagen { get; set; }

        public ImagenesBE()
        {
        }
    }
}