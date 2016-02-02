using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MyLogin
{
    class HashCode
    {
        public string PassHash(string data)
        {
            SHA1 sha = SHA1.Create();
            //sha encryption method
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            //srting of bytes encoded in the array
            StringBuilder returnValue = new StringBuilder();
            for(int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }
            
            return returnValue.ToString();
        }
    }
}
