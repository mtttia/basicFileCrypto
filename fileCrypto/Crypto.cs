using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileCrypto
{
    public class Crypto
    {
        private int _key;
        public int Key
        {
            get
            {
                return _key;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("key must be positive");
                }
                _key = value;
            }
        }
        public string Content { get; set; }
        public Crypto(string c, int k)
        {
            Content = c;
            Key = k;
        }
        public string Encrypt()
        {
            string xorred = Xor(Content, GenerateKey(Key, Content.Length));
            string b64 = EncodeTo64(xorred);
            return StringToBinary(b64);
        }
        public string Decrypt()
        {
            string bin = BinaryToString(Content);
            string b64 = DecodeFrom64(bin);
            return Xor(b64, GenerateKey(Key, b64.Length));
        }

        private string GenerateKey(int starter, int length)
        {
            string s = starter.ToString();
            Random rnd = new Random(starter);
            int n = 9;
            while (s.Length < length)
            {
                s += rnd.Next((int)Math.Pow(10, n - 1), (int)Math.Pow(10, n)); //generate number with 9 digits
            }
            return s;
        }

        private string Xor(string a, string b)
        {
            if (a.Length <= b.Length)
            {
                string ret = "";
                for (int i = 0; i < a.Length; i++)
                {
                    char c = ToChar(ToInt(a[i]) ^ ToInt(b[i]));
                    ret += c;
                }
                return ret;
            }
            throw new Exception("values not valid");
        }
        private int ToInt(char c)
        {
            return (int)c;
        }
        private char ToChar(int i)
        {
            return (char)i;
        }
        private string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        private string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }
        private string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        private string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}
