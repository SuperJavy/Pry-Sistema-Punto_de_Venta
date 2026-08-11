    using MySqlConnector;
    using System.Runtime.CompilerServices;
    using System.Text;
    using ZXing;
    using ZXing.SkiaSharp;

    namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
    {
        internal class ECodigodebarras
        {
            public string ObtenerNumeroUnicoEInexistente()
            {
                bool yaExiste = true;
                string numeroCandidato = "";

                while (yaExiste)
                {
                    numeroCandidato = GenerarNumeroAleatorio();
                    yaExiste = ExisteEnBaseDeDatos(numeroCandidato);
                }
                return numeroCandidato;
            }

            public string GenerarNumeroAleatorio()
            {
                Random random = new Random();
                StringBuilder resultado = new StringBuilder();
                string prefijoPais = "750";
                resultado.Append(prefijoPais);

                for (int i = 0; i < 10; i++)
                {
                    resultado.Append(random.Next(0, 10));
                }

                return resultado.ToString();
            }

        public bool ExisteEnBaseDeDatos(string numero)
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();

                // Buscamos en ambas tablas para garantizar que sea 100% único
                string Query = @"
            SELECT codigo FROM (
                SELECT Codigo_barras AS codigo FROM codigo_Barras
                UNION
                SELECT codigo_de_barras AS codigo FROM productos WHERE codigo_de_barras IS NOT NULL
            ) AS codigos_totales 
            WHERE codigo = @codigo LIMIT 1;";

                using (var conex = conexionBD.abrirConexion())
                using (var consulta = new MySqlCommand(Query, conex))
                {
                    consulta.Parameters.AddWithValue("@codigo", numero);

                    // ExecuteScalar es la forma más rápida de saber si existe al menos un registro
                    object resultado = consulta.ExecuteScalar();

                    if (resultado != null)
                    {
                        return true; // El código ya existe, el bucle while generará otro
                    }
                }
                return false; // El código está libre
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar disponibilidad del código de barras: " + ex.Message);
            }
        }

        public Image imgcodeb(string textoAleatorio)
            {
                // ELIMINAMOS la línea que generaba un número nuevo aquí adentro

                var escritor1D = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 350,
                        Height = 120,
                        Margin = 10,
                        PureBarcode = false
                    }
                };

                try
                {
                    using (var dibujoSkia = escritor1D.Write(textoAleatorio))
                    {
                        using (var imagenReal = SkiaSharp.SKImage.FromBitmap(dibujoSkia))
                        using (var datosImagen = imagenReal.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100))
                        using (var streamMemoria = new MemoryStream(datosImagen.ToArray()))
                        {
                            return Image.FromStream(streamMemoria);
                        }
                    }
                }
                catch (Exception error)
                {
                    throw new Exception("Error al generar el código de barras 1D: " + error.Message);
                }

            }
        public bool insertarBD(string codigo, Image img)
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conex = conexionBD.abrirConexion())
                {
                    string Query = "INSERT INTO codigo_Barras (Codigo_barras, img_codigoDeBarras, id_estado) VALUES (@codigo, @img, @estado);";
                    using (var consulta = new MySqlCommand(Query, conex))
                    {
                        consulta.Parameters.AddWithValue("@codigo", codigo);
                        consulta.Parameters.AddWithValue("@img", imagenABytes(img));
                        consulta.Parameters.AddWithValue("@estado", 2); // Asignamos el estado 2 directamente

                        // Para INSERT, UPDATE o DELETE siempre usamos ExecuteNonQuery
                        int filasAfectadas = consulta.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el código de barras generado: " + ex.Message);
            }
        }
        private byte[] imagenABytes(Image img)
            {
                if (img == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }

            private Image BytesAImagen(byte[] bytes)
            {
                if (bytes == null || bytes.Length == 0) return null;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }

        }
    }

