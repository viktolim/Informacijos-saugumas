using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESalgorithm
{
    class LineMatrica
    {
        string colum = null;                                                      
        string row = null;                                                          
        DataTable matrica;

        public LineMatrica(string find, DataTable matrica)
        {
            this.matrica=matrica;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (matrica.Rows[i].ItemArray[j].ToString() == find)        //tikrina ar matricos eilutėje esantis skaičius yra toks kurį skaičiu norima rasti
                    {
                        colum = j.ToString();                                   //suradus tą skaičių matricoje priskiriamas stulpelis kuris yra matricoje nurodytas
                        row=i.ToString();                                       //priskiriama eilutė kuri yra nudoryta matricoje rasto skaičiaus
                    }
                }
            }
        }
        public int getColum()
        {
            if(colum!=null)return int.Parse(colum);                             //jei stulpelis nėra nulis, grąžinamas priskirtas stulpelis
            else { throw new Exception("Nera");  }                              // kitu atveju grąžinimas neįvyksta
        }
        public int getRow()
        {
            if(row!=null)return int.Parse(row);                                 //jei eilutė nėra nulis, grąžinama priskirta eilutė
            else { throw new Exception("Nera"); }                               // kitu atveju grąžinimas neįvyksta
        }
        public string[] getBusenosMatrica()
        {
            string[] temp = new string[4];                                      //sukūriami konteineriai kuriuose bus talpinama būsenos matricos eilutė
            for (int i = 0; i <4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if(j==getColum())                                           //jei rastas stulpelio vieta yra matricos stulpelio vieta
                    {
                        temp[i] = matrica.Rows[i].ItemArray[j].ToString();      //tuomet stulpelis įrašoma į array
                    }
                }
            }
            return temp;                                                        //grąžina matricos būsenos stulpelį
        }
        public string[] getMatrica()
        {
            string[,] matr = new string[,] { { "02", "03", "01", "01" }, { "01", "02", "03", "01" }, { "01", "01", "02", "03" }, { "03", "01", "01", "02" } }; //Matricos priskirimas kuris yra reikalingas AES skaičiavimui
            string[] temp = new string[4];                                      //sukūriami konteineriai kuriuose bus talpinama matricos eilutė
            int d = 0;                                                          //būsenos matricos vieta yra priskirta nuliui
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == getRow())                                          //jei rastas eilutės vieta yra matricos eilutės vieta
                    {
                        temp[d] = matr[i, j];                                   //tuomet eilutė įrašoma į array
                        d++;                                                    //matricos eilutės numeris didėja
                    }
                }
            }
            return temp;                                                        //grąžina matricos eilutę
        }
            
    }
}
