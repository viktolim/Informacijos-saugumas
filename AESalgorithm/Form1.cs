using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AESalgorithm
{
    public partial class Form1 : Form
    {
        static DataTable currentGrid = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetMatricaButton_Click(object sender, EventArgs e)
        {
                                
        }

        private void createMatricaButton_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            SetAts.Text = dataService.GetTextFromFile();
        }

        private void SifravButton_Click(object sender, EventArgs e)
        {
            if(SetAts.Text!=null && SetAts.Text!="" && SetModa.Text != null && SetModa.Text != "")                                               //Patikrina ar duomenys yra įrašyti lentelėje ir priskiriama kokia reikšmė bus ieškoma
            {
                try
                {
                    Algorithm algorithm = new Algorithm();
                    GetAts.Text = algorithm.encryption(SetAts.Text, SetModa.Text,setKodas.Text);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nėra tokio skaičiaus");
                }
            }
           
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();                                                                //sukūriama klasė kurioje galima išsaugoti į txt failą duomenys
         
            dataService.SaveFile("Šifravimas AES algoritmu: "+SetAts.Text+"->"+ GetAts.Text);                           // išsaugomas nurodytas tekstas
            
        }
    }
}
