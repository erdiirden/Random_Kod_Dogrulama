using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Bsg3Hafta
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 100000; 
            int max = 999999; 
            int randomPassword = random.Next(min, max + 1); 
            string password = randomPassword.ToString("D6"); // string çevirme

            
            Form2 form2 = new Form2();
            form2.gelenKod = password;
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
