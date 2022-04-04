using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AESalgorithm
{
    class Algorithm
    {
        private AesCryptoServiceProvider provider;
        public Algorithm()
        {
            provider = new AesCryptoServiceProvider();
            provider.BlockSize = 128;                     
            provider.GenerateIV();
            provider.Padding = PaddingMode.PKCS7;
        }
        public string encryption(string input, string moda,string kodas)
        {
            setKey(kodas);
            return Convert.ToBase64String(provider.Key);
            setModa(moda);
            setKey(kodas);
            ICryptoTransform transform = provider.CreateEncryptor();
            byte[] encrypted = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(input), 0, input.Length);
            return Convert.ToBase64String(encrypted);
        }
        private void setModa(string moda)
        {
            if (moda == "CBC") provider.Mode = CipherMode.CBC;
            else if (moda == "CFB") provider.Mode = CipherMode.CFB;
            else if (moda == "CFB") provider.Mode = CipherMode.CFB;
            else if (moda == "ECB") provider.Mode = CipherMode.ECB;
            else if (moda == "OFB") provider.Mode = CipherMode.OFB;
        }
        private void setKey(string kodas)
        {
          
           if (kodas =="128")
            {
                provider.KeySize = 128;
            }
            else if (kodas == "192")
            {
                provider.KeySize = 192;
            }
            else if (kodas == "256")
            {
                provider.KeySize = 256;
            }
            else
            {
                provider.GenerateKey();
            }
        }
    }
}
