using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataService dataService = new DataService(@"C:\Users\Viktorija\source\repos\AESalgorithm\BusenosMatrica.xls"); //sukūriama klasė kuriai priskiriamas iš kur reikės nuskaityti failą
            currentGrid= dataService.DataServerFromExcel();                                                                //Nuskaitomas excel failas
            dataGrid.DataSource = currentGrid;                                                                             //perduodama matrica išvedimui į UI duomenų lentelę
        }

        private void createMatricaButton_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();                                                                  //sukūriama klasė kurios paskirtis dirbti su duomenimis
            currentGrid = dataService.NewDataTable();                                                                     //sukūriama tuščia lentelė
            dataGrid.DataSource = currentGrid;                                                                            //priskiriama tuščia lentelė UI išvedimui

        }

        private void SifravButton_Click(object sender, EventArgs e)
        {
            if(currentGrid!=null && SetAts.Text!="" && SetAts.Text != null)                                               //Patikrina ar duomenys yra įrašyti lentelėje ir priskiriama kokia reikšmė bus ieškoma
            {
                try
                {
                    AES aes = new AES();                                                                                   //sukūriamas aes klasė
                    string symbol = aes.getAes(currentGrid, SetAts.Text);                                                  //naudojamas kodo gavimo metodas priskiriant matricą ir kokį radimo skaičių norima šifruoti
                    GetAts.Text = char.ToUpper(symbol[0]).ToString() + char.ToUpper(symbol[1]).ToString();

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
