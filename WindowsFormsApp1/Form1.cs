using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int intdeger;

        public void button1_Click(object sender, EventArgs e)
        {/*

            if (listBox1.SelectedItem != null)
            {
                try
                {
                    intdeger = Convert.ToInt32(listBox1.SelectedItem); // Convert.ToInt32 kullanarak dönüştürme

                }
                catch (OverflowException)
                {
                    MessageBox.Show("Dönüşüm sınırları aşıldı.");
                }
                this.Hide();
                UnoOyun form2 = new UnoOyun();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }*/
            this.Hide();
            UnoOyun form2 = new UnoOyun();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
