using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace terminal1._0
{
    class Security
    {
        public string calculateMD5Hash(string input)
        {
            //dorost kardan MD5 Hash coding
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            //ارایه ای از نوع بایت که شامل متن ورودی ماست
            byte[] inputByte = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputByte);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString().ToLower();
        }

        private static string CreatRandomPass(int passLen)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Byte[] randomBytes = new Byte[passLen];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);
            Char[] chars = new Char[passLen];
            int charCount = allowedChars.Length;
            for (int i = 0; i < passLen; i++)
                chars[i] = allowedChars[(int)randomBytes[i] % charCount];
            return new string(chars);
        }
    }
}
