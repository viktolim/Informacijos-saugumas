using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESalgorithm
{
    class Algorithm
    {
        string firstNumber;
        string secondNumber;
        public string GetValue(string a, string b)
        {
            if (a[1] == '1')                                                                                //jei skaičiaus antras skaitmuo yra vienas
            {
                firstNumber = ConvertHexadecimalToBinary(b[0].ToString());                                  //pirmam skaičiui surandami 4 bitų dvejetainis skaičius
                secondNumber=ConverttBits(Convert.ToString(int.Parse(ConvertHexadecimalToBinary(a[1].ToString())) * int.Parse(ConvertHexadecimalToBinary(b[1].ToString()))));  //antram skaičiui surasti naudojama formulė
                return ConverttBits(firstNumber) + secondNumber;                                            //grąžina pirma 4 bitų ir antrą 4 bitų surastą dvejetainę eilutę
            }
            else
            {
                string binary = ConvertToEightBits(ConvertHexadecimalToBinary(b.ToString()));               //būsenos matricos skaičius paverčiamas į dvejetainį ir pertvarkomas į 8 bitų eilutę   
                if (binary[0] == '0')                                                                       //jei dvejetainio skaičiaus pirmas dėmuo yra nulis, tuomet atliekama
                {  
                    firstNumber = DeleteFirstBit(binary);                                                   //eilutės pirmo dėmes šalinimas ir pridedant į galą 0

                }
                else if (binary[0] == '1')                                                                  //jei dvejetainio skaičiaus pirmas dėmuo yra vienas, tuomet atliekama
                {
                    firstNumber = SumBinaryNumbers(DeleteFirstBit(binary), ConvertToEightBits(ConvertHexadecimalToBinary("1B")));   //šalinama pirmas dėmuo ir pridedamas 1B, kuris yra konvertuotas į dvejetainį skaičių ir 8 bitų eilutė
                }
                if (a[1] == '2') return firstNumber;                                                        //jei matricos antras elementas yra du, tuomet grąžina gautą atsakymą
                else
                {
                    return SumBinaryNumbers(firstNumber, ConvertToEightBits(ConvertHexadecimalToBinary(b)));    //kitu atveju grąžinamas apskaičiuotas skaičius pridedant konvertuotą matricos elementą į dvejetainį ir aštuonių bitų
                }

            }
        }
        private string ConvertHexadecimalToBinary(string hexadecimal)
        {
            return Convert.ToString(Convert.ToInt32(hexadecimal, 16), 2);                                   //grąžinamas konvertuotas 16 skaičius į dvejetainį
        }
        private string SumBinaryNumbers(string number, string number2)
        {
            string temp = null;                                                                             //eilutei priskiriama tuščia vieta
            for (int i = 0; i <8; i++)
            {

                temp = temp + ((int)number[i] + (int)number2[i]) % 2;                                       //sudedami dvejetainiai skaičiai

            }

            return temp;                                                                                    //grąžinamas sudėtas dviejų binary skaičių elementai
        }
        private string DeleteFirstBit(string number)
        {
            string temp = null;             //eilutei priskiriamas tuščias domuo
            for (int i = 1; i < 8; i++)
            {
                temp = temp + number[i];   //7 kartus vyksta ciklas ir nuskaitomi paskutiniai 7 duomenys 
            }
            return temp + "0";              //grąžinamas skaičius kuriam nuimtas pirmas elementas ir pridėtas į galą 0
        }
        private string ConvertToEightBits(string number)
        {
            string temp = number;           // laikinai eilutei priskiriami skaičiai kurie nurodyti kviečiant  metodą
            while(temp.Length<8)            //kol eilutėje nurodyti elementai bus mažiau nei 8 bitų
            {
                temp = "0" + temp;          //tol eilutėje bus pridėdami 0 skaičius į eilutės priekį
            }
            if(temp.Length>8)               //jei eilutė yra daugiau nei 8 skaitmenys
            {
                temp = null;                //eilutei priskiriamas tuščia eilutė
                for (int i = 0; i < 8; i++)
                {
                    temp = temp + number[i]; //į eilutę pridedami skaičiai kurie yra įvesti, nuskaito 8 bitus
                }
            }
            return temp;                    //grąžinama 4 bitų eilutę
        }
        private string ConverttBits(string number)
        {
            string temp = number;            // laikinai eilutei priskiriami skaičiai kurie nurodyti kviečiant  metodą
            while (temp.Length < 4)         //kol eilutėje nurodyti elementai bus mažiau nei 4 bitų
            {
                temp = "0" + temp;          //tol eilutėje bus pridėdami 0 skaičius į eilutės priekį
            }
            if (temp.Length > 4)            //jei eilutė yra daugiau nei 4 skaitmenys
            {
                temp = null;                //eilutei priskiriamas tuščia eilutė
                for (int i = 0; i < 4; i++)
                {
                    temp = temp + number[i]; //į eilutę pridedami skaičiai kurie yra įvesti, nuskaito 4 bitus
                }
            }
            return temp;                    //grąžina 4 bitų eilutę
        }

    }
}
