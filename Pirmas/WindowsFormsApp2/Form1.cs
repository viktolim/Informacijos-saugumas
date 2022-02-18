using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            setError.Text = null;
            if (SetKey.Text != null && SetText.Text != null && SetKey.Text != "" && SetText.Text != "") 
            {
            int keySize = 0;
            TextGet.Text = null;
            int key;
            int m = 0, k = 0;
                for (int i = 0; i < SetText.Text.Length; i++)
                {
                    for (int j = 33; j < 127; j++)
                    {
                        if (SetText.Text[i] == (char)+j)
                        {
                            for (int p = 33; p < 127; p++)
                            {
                                if (SetKey.Text[keySize] == (char)+p)
                                {
                                    if (m + k > 93) key = (m + k - 1) % 93;
                                    else { key = m + k % 93; }
                                    TextGet.Text = TextGet.Text + (char)+(33 + (key));
                                }

                                k++;
                            }
                            k = 0;

                        }
                        m++;
                    }
                    m = 0;
                    keySize++;
                    if (keySize >= SetKey.Text.Length) keySize = 0;
                }
            }
            else
            {
                setError.Text = "Įveskite tekstą į laukelius";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            setError.Text = null;
            if (SetKey.Text != null && SetText.Text != null && SetKey.Text != "" && SetText.Text != "")
            {
                int keySize = 0;
                TextGet.Text = null;
                int key;
                int m = 0, k = 0;
                for (int i = 0; i < SetText.Text.Length; i++)
                {
                    for (int j = 33; j < 127; j++)
                    {
                        if (SetText.Text[i] == (char)+j)
                        {
                            for (int p = 33; p < 127; p++)
                            {
                                if (SetKey.Text[keySize] == (char)+p)
                                {
                                    if (m - k >= 0) key = m - k;
                                    else { key = m - k + 94; }
                                    TextGet.Text = TextGet.Text + (char)+(33 + (key));
                                }
                                k++;
                            }
                            k = 0;

                        }
                        m++;
                    }
                    m = 0;
                    keySize++;
                    if (keySize >= SetKey.Text.Length) keySize = 0;
                }
            }
            else
            {
                setError.Text = "Įveskite tekstą į laukelius";
            }
        }
    }
}
