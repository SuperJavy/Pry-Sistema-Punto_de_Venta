using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Sistema_Punto_de_Venta.Modelo
{
    internal class ClsCorteCajaModelo: ClsConexion
    {
        public static int IdCorteActual { get; private set; }

        public bool AbrirCaja(int idUsuario, decimal montoInicial)
        {
            string query = @"INSERT INTO corte (id_usuario, fecha_inicial, monto_inicial, monto_esperado) 
                             VALUES (@id_usuario, NOW(), @monto_inicial, @monto_inicial);
                             SELECT LAST_INSERT_ID();";
            try
            {
                using (var conexion = abrirConexion())
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@monto_inicial", montoInicial);
                    IdCorteActual = Convert.ToInt32(cmd.ExecuteScalar());
                    return IdCorteActual > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir caja: " + ex.Message);
            }
        }

    }

}
