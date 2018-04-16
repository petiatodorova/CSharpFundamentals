using System;
using System.Text;
using System.Text.Encoding;


namespace Probi1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
            byte[] myString = System.Text.Encoding.ASCII.GetString(asciiBytes);


        }
        
    }
}
