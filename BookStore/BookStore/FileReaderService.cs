using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookStore
{
    public class FileReaderService
    {
        public string path = @"C:\Users\Dell\source\repos\BookStore\BookStore\TxtFiles\Books";
        public void FileReader()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine(EndOfStreamException);
            }

        }
        
    }
}
