using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure.Extensions
{
    public static class SecurityExtension
    {
        public const int Lisans_Kodlayici_Key = 111222778;
        public static string Sifrele(string Deger)
        {
            string Sifrelenecek = Deger;
            string Sifrelendi = null;
            for (int i = 0; i < Sifrelenecek.Length; i++)
            {
                Sifrelendi += (char)(Sifrelenecek[i] ^ Lisans_Kodlayici_Key);
            }
            return Sifrelendi;
        }

        public static string Sifre_Coz(string Deger)
        {
            string Sifreli = Deger;
            string Sifresiz = null;
            for (int i = 0; i < Sifreli.Length; i++)
            {
                Sifresiz += (char)(Sifreli[i] ^ Lisans_Kodlayici_Key);
            }
            return Sifresiz;
        }

        public static string Sifre_Uret()
        {
            string deger = "";
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int karar = rnd.Next(0, 2); 
                if (karar == 0)
                {
                    int sayi = rnd.Next(1, 10);
                    deger += sayi.ToString();
                }
                else
                {
                    int x = rnd.Next(65, 91);
                    char harf = Convert.ToChar(x);
                    deger += harf;
                }
            }
            return deger;
        }

        public static string ConvertStringToMD5(this string ClearText)
        {
            byte[] ByteData = Encoding.ASCII.GetBytes(ClearText);
            MD5 oMd5 = MD5.Create();
            byte[] HashData = oMd5.ComputeHash(ByteData);
            StringBuilder oSb = new StringBuilder();
            for (int x = 0; x < HashData.Length; x++)
            {
                oSb.Append(HashData[x].ToString("x2"));
            }
            return oSb.ToString();
        }

    }
}
