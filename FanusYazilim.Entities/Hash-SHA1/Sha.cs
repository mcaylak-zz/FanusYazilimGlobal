using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.Entities.Hash_SHA1
{
    public static class Sha
    {
        public static string Encoder(string data)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashData = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(data)));

            return hashData;
        }
    }
}
