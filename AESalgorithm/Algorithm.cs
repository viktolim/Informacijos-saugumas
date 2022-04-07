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
        private string encrypt;
        public Algorithm()
        {
            provider = new AesCryptoServiceProvider();
            provider.Padding = PaddingMode.PKCS7;

        }
        public string encryption(string input, string moda, string kodas, string vector, int des)
        {
            try
            {
                setKey(kodas);
                setModa(moda, vector);
                ICryptoTransform transform;
                provider.BlockSize = kodas.Length * 8;
                if (des == 1)
                {
                    setModa(moda, vector);
                    transform = provider.CreateEncryptor();
                    byte[] src = Encoding.UTF8.GetBytes(input);
                    byte[] encrypted = transform.TransformFinalBlock(src, 0, src.Length);
                    encrypt = Convert.ToBase64String(encrypted);
                    return BitConverter.ToString(encrypted).Replace(" - ", " ");
                }
                else
                {
                    transform = provider.CreateDecryptor();
                    byte[] src = Convert.FromBase64String(input);
                    byte[] encrypted = transform.TransformFinalBlock(src, 0, src.Length);
                    return Encoding.UTF8.GetString(encrypted);
                }

            }
            catch(Exception e)
            {
                return null;
            }
     
        }
        private void setModa(string moda, string vector)
        {
            if (moda == "CBC")
            {
                provider.Mode = CipherMode.CBC;
                provider.IV = Encoding.UTF8.GetBytes(vector);
            }
            else
            {
                provider.Mode = CipherMode.ECB;
            }
        }
        private void setKey(string input)
        {
            provider.KeySize = input.Length * 8;
            provider.Key = Encoding.UTF8.GetBytes(input);
        }
        public string baseEncrypt()
        {
            return encrypt;
        }

    }
}
