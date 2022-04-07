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
            DataService dataService = new DataService();
            setText.Text = dataService.GetTextFromFile();
        }

        private void createMatricaButton_Click(object sender, EventArgs e)
        {
            if (Encrypted.Text != null && Encrypted.Text != "" && setKey != null && setKey.Text != "" && chooseKey.Text != null && chooseKey.Text != "" && chooseModa.Text != null && chooseModa.Text != "")
            {

                if (int.Parse(chooseKey.Text) == setKey.Text.Length * 8)
                {
                    if (chooseModa.Text == "CBC")
                    {
                        if (setVector.Text.Length * 8 == 128)
                        {
                            Algorithm algorithm = new Algorithm();
                            encryptedAts.Text = algorithm.encryption(Encrypted.Text, chooseModa.Text, setKey.Text, setVector.Text, 2);
                        }
                        else
                        {
                            MessageBox.Show("Vektorius turi būti sudarytas iš 16 simbolių");
                        }
                    }
                    else
                    {
                        Algorithm algorithm = new Algorithm();
                        encryptedAts.Text = algorithm.encryption(Encrypted.Text, chooseModa.Text, setKey.Text, null, 2);
           
                    }
                }
                else
                {
                    MessageBox.Show("Rakto dydis turi atitikti įvesto rakto dydžiui");
                }

            }
            else
            {
                MessageBox.Show("Būtini laukai yra tušti");
            }

        }

        private void SifravButton_Click(object sender, EventArgs e)
        {
            if(setText.Text!=null && setText.Text!="" && setKey!=null && setKey.Text!="" && chooseKey.Text!=null&& chooseKey.Text != "" && chooseModa.Text!= null && chooseModa.Text != "")
            {
               
                if(int.Parse(chooseKey.Text)==setKey.Text.Length*8)
                {
                    if (chooseModa.Text == "CBC")
                    {
                        if (setVector.Text.Length * 8 == 128)
                        {
                            Algorithm algorithm = new Algorithm();
                            getAts.Text = algorithm.encryption(setText.Text, chooseModa.Text, setKey.Text,setVector.Text,1);
                            getAtsBase.Text = algorithm.baseEncrypt();
                        }
                        else
                        {
                            MessageBox.Show("Vektorius turi būti sudarytas iš 16 simbolių");
                        }
                    }
                    else
                    {
                        Algorithm algorithm = new Algorithm();
                        getAts.Text = algorithm.encryption(setText.Text, chooseModa.Text, setKey.Text, null, 1);
                        getAtsBase.Text = algorithm.baseEncrypt();
                    }
                }
                else
                {
                    MessageBox.Show("Rakto dydis turi atitikti įvesto rakto dydžiui");
                }

            }
            else
            {
                MessageBox.Show("Būtini laukai yra tušti");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();                                                                //sukūriama klasė kurioje galima išsaugoti į txt failą duomenys
         
            dataService.SaveFile("Šifravimas AES algoritmu: "+setText.Text+"->"+ getAts.Text);                           // išsaugomas nurodytas tekstas
            
        }

        private void SetModa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
