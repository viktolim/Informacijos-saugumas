using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int n = 31;
            string M = SetText.Text;
            char m;
            int mSize =SetText.Text.Length;
            SetText.Text = null;
            int ArrayLoc;
            char[] array = new char[] { 'a','ą','b','c','č','d','e','ę','ė','f','g','h','i','į','y','j','k','l','m','n','o','p','r','s','š','t','u','ų','ū','v','z','ž'};
            for(int i=0; i<mSize; i++)
            {
                m = M[i];
                for(int j=0; j<n; j++)
                {
                    if (array[j] == m)
                    {
                        ArrayLoc = int.Parse(kSet.Value.ToString());
                        if(j+ArrayLoc > n)
                        {
                            SetText.Text = SetText.Text + array[((j + ArrayLoc)-n)-1];
                        }
                        else
                        {
                            SetText.Text = SetText.Text + array[j + ArrayLoc];
                        }

                    }
                }
            }
        }
    }
}
