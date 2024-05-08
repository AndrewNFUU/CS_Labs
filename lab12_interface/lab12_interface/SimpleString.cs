using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_interface
{
    interface IExtendString
    {
        string Concatenate(string other);
        string MirrorString();   

    }


    internal class SimpleString : 
                    IExtendString, 
                    ICloneable,
                    IComparable
    {
        private string _str;
        private byte _byteSize;
        private int _intSize;

        public string Str
        {
            get { return _str; }
            set 
            { 
                _str = value; 
                CalculateStringSize();
            }
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
            Str = "";
            CalculateStringSize();
        }

        public SimpleString(string newStr)
        {
            Str = newStr;
            CalculateStringSize();
        }

        public SimpleString(char newChar)
        {
            Str = newChar.ToString();
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
            Str = "";
            CalculateStringSize();
        }

        public override string ToString()
        {
            return Str.ToString();
        }


        // --------------- interface ---------------
        public virtual string Concatenate(string other)
        {
            return this.Str + other;
        }

        public virtual string MirrorString()
        {
            char[] charArr = Str.ToCharArray();

            Array.Reverse(charArr);

            string mirrorStr = new string(charArr);

            return mirrorStr;
        }


        public object Clone()
        {
            SimpleString clonedString = new SimpleString();

            clonedString.Str = this.Str;

            clonedString.CalculateStringSize();

            return clonedString;
        }


        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1; 

            SimpleString other = obj as SimpleString;
            if (other != null)
            {
                return this.Str.CompareTo(other.Str);
            }
            else
            {
                throw new ArgumentException("Object is not a Simple String");
            }
        }
    }
}
