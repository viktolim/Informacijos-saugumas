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
        public DataTable DataServerFromExcel()
        {
            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + fileLocation + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;\'";    
            OleDbConnection connection = new OleDbConnection(con);                      //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
            OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection); //priskiriama ką turės padaryti
            connection.Open();              
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = command;                                                //Nuskaitomi visi duomenys kurie yra įvesti excel puslapyje Sheeet1
            DataTable dt = new DataTable();
            sda.Fill(dt);                                                               //duomenys įrašomi į lentelę                                                
            return dt;                                                                  //grąžinami įrašyta lentelė kuri yra nuskaityta nuo excel

        }
        public DataTable NewDataTable()                                                 //grąžina tuščią lentelė kurios column priskiriami pavadinima
        {
            DataTable dt = new DataTable();
            for (int i = 1; i <= 4; i++)
            {
                dt.Columns.Add(i + " stulpelis");
                if (i != 4) dt.Rows.Add("");
            }
            return dt;
        }
        public void SaveFile(string text)           //išsaugomas failas į nurodytą txt failą
        {
            TextWriter txt = new StreamWriter(@"C:\Users\Viktorija\source\repos\AESalgorithm\Result.txt");
            txt.Write(text);
            txt.Close();
        }
    }
}
