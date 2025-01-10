using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public class Random
    {
        public int Next(int n)
        {
            var byteArray = new byte[4];
            RandomNumberGenerator.Fill(byteArray);

            var randomInteger = BitConverter.ToUInt32(byteArray, 0);
            return (int)(randomInteger % n);
        }
    }
}