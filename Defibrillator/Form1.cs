using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defibrillator
{
    public partial class frmDefibrillator : Form
    {
        public frmDefibrillator()
        {
            InitializeComponent();
            Beolvasas();
        }

        static List<Keszulek> keszulek = new List<Keszulek>();

        public void Beolvasas()
        {
            StreamReader sr = new StreamReader("data.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                keszulek.Add(new Keszulek(Convert.ToInt32(adat[0]), adat[1], Convert.ToDouble(adat[2]),
                    Convert.ToDouble(adat[3]), adat[4], adat[5]));
            }
            sr.Close();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static double megadottX;

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            //x = Convert.ToDouble(Console.ReadLine());
            //tbX.Text = Convert.ToString(x);

            tbX.Text = Console.ReadLine();
            megadottX = Convert.ToDouble(tbX.Text);
        }

        static double megadottY;

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            tbY.Text = Console.ReadLine();
            megadottY = Convert.ToDouble(tbY.Text);
        }

        public void DistCalc(double x, double y)
        {
            double min = 1000000000;
            string telszam = "";
            string cim = "";
            foreach (var k in keszulek)
            {
                double d = 0;
                x = (megadottX - k.Longitude) * Math.Cos((megadottY + k.Latitude) / 2);
                y = megadottY - k.Latitude;
                d = Math.Sqrt((x * x) + (y * y)) * 6371;
                if (min > d)
                {
                    min = d;
                    telszam = k.Tel;
                    cim = k.Address;
                }
            }

            lbEredmeny.Items.Add($"A legközelebb elérhető készülék:\n Telefonszám: {telszam}\n" +
                $"Cím: {cim}");
        }

        private void btnLekeres_Click(object sender, EventArgs e)
        {
            DistCalc(megadottX, megadottY);
        }

        private void btnUjAdat_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Clear();
            tbX.Clear();
            tbY.Clear();
        }
    }
}
