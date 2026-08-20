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
                if (numero == "123456789012")
                {
                    return true;
                }

                return false;
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
            public bool insertarBD(string codigo)
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conex = conexionBD.abrirConexion())
                {
                    string Query = "INSERT INTO codigo_Barras (Codigo_barras, id_estado) VALUES (@codigo,@estado);";
                    using(var consulta = new MySqlCommand(Query, conex))
                    {
                        consulta.Parameters.AddWithValue("@codigo",codigo);
                    consulta.Parameters.AddWithValue("@estado", int.Parse("2"));
                        using (var result = consulta.ExecuteReader())
                        {
                            if (result.Read())
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }

                        }
                    
                    }
                }
            }
        

        }
    }

