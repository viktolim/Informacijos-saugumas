using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESalgorithm
{
    class DataService
    {
        string fileLocation;
        public DataService(string fileLocation)
        {
            this.fileLocation= fileLocation;    //Priskiriamas failo vieta atributui
        }
        public DataService() { }
        public void SaveFile(string text)           //išsaugomas failas į nurodytą txt failą
        {
            TextWriter txt = new StreamWriter(@"C:\Users\Viktorija\source\repos\AESalgorithm\Result.txt");
            txt.Write(text);
            txt.Close();
        }
        public string GetTextFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Viktorija\source\repos\AESalgorithm\Data.txt");
                string line = sr.ReadLine();
                sr.Close();
                return line;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }

        }
    }
}
