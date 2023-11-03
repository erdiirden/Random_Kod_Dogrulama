using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Bsg3Hafta
{
    public partial class Form2 : Form
    {
        public string gelenKod = "";
        public bool sureKontrol = false;
        private bool sureDolduMu = false;
        private int kalanSure = 60; // İlk başta 60 saniye
        private Timer timer;
        public Form2()
        {
            InitializeComponent();
            InitializeTimer();
        }


        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye (1000 milisaniye)
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (kalanSure > 0)
            {
                kalanSure--;
                label3.Text = "Kalan Süre: " + kalanSure.ToString() + " saniye";
            }
            else
            {
                timer.Stop(); // Süre doldu, Timer'ı durdur
                sureDolduMu = true;
                label3.Text = "     Süre Doldu!";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Gelen Kod: "+ gelenKod;
            label3.Text = "Kalan Süre: 60 saniye";
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sureDolduMu==false)
            {
                if (textBox1.Text == gelenKod)
                {
                    MessageBox.Show("Kod Doğrulandı");
                }
                else
                {
                    MessageBox.Show("Kod Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Süre Zaman Aşımı");
            }
        }
    }
}
