using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class clsConexion
    {
       // private readonly string cadeConexion = "Server=localhost;Database=punto_de_venta;Uid=root;Pwd=123456;";
        private readonly string cadeConexion = "Server=localhost;Database=punto_de_venta;Uid=root;Pwd=;";

        protected MySqlConnection conexion;
        public MySqlConnection abrirConexion()
        {
            conexion = new MySqlConnection(cadeConexion);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }

    }

}

