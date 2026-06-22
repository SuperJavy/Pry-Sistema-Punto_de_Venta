using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pry_Sistema_Punto_de_Venta.Modelo.Entidades
{
    internal class encryptado
    {
        public string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                byte[] hasBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hasBytes).Replace("-", "").ToLower();

            }

        }

    }
}
