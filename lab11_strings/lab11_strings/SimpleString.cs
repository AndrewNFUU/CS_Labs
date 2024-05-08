using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_strings
{
    internal class SimpleString
    {
        private string _str;
        private byte _byteSize;
        private int _intSize;

        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }

        public byte ByteSize
        {
            get { return _byteSize; }
        }

        public int IntSize
        {
            get { return _intSize; }
        }

        public SimpleString()
        {
            _str = "";
            CalculateStringSize();
        }

        public SimpleString(string newStr)
        {
            _str = newStr;
            CalculateStringSize();
        }

        public SimpleString(char newChar)
        {
            _str = newChar.ToString();
            CalculateStringSize();
        }

        private void CalculateStringSize()
        {
           /* // num of bytes divided by 2, because UTF-16 use 2 bytes per char
            _byteSize = (byte)(Encoding.Unicode.GetByteCount(_str) / 2);*/
           
            _byteSize = (byte)Encoding.Unicode.GetByteCount(_str);

            _intSize = _str.Length;
        }

        public void ClearString()
        {
            _str = "";
            CalculateStringSize();
        }

        public override string ToString()
        {
            return _str.ToString();
        }
    }
}
