using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESalgorithm
{
    class AES
    {
        public string getAes(DataTable data,string find)
        {
            string[] temp = new string[4];                              //priskiriamas konteineriai matricos eilutei išsaugoti
            LineMatrica lineMatrica = new LineMatrica(find, data);      //sukūriama klasė kuriai priskiriami atributai, kokio skaičiau kodą norimą rasti ir matrica 
            string[] a = lineMatrica.getMatrica();                      //surandama matricos eilutė
            string[] b = lineMatrica.getBusenosMatrica();               //surandama būsenos matricos stulpelis
            Algorithm algorithm = new Algorithm();                      //sukūriama klasė pagal kurią bus vykdotas algoritmas- skaičiavimas
            for (int i = 0; i < 4; i++)
            {
                temp[i]=algorithm.GetValue(a[i], b[i]);                 //sudėti ir sudauginti eilučių dvejetainiai skaičiai             
            }
            return sumValues(temp);                                     //grąžinamas gautų eilučių sudėtis ir pakeistas į 16 skaičių
        }
        private string sumValues(string[] data)
        {
            string temp = null;                                         //priskiriama tuščia eilutė 
            int sk;
            for(int i=0; i<8; i++)
            {
                sk = ((data[0])[i] + (data[1])[i]+ (data[2])[i]+ (data[3])[i])%2;   //eilučių binary skaičių sudėties apskaičiavimas
                temp = temp + sk.ToString();                                        //pridėjimas į eilutės vietą gauta suma
            }
            return Convert.ToString(Convert.ToInt32(temp, 2), 16);                  //grąžinama eilutė kurioje buvo sudėti array binary elementai ir pakeistas į 16 skaičių
        }
    }
}
