using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_Aplikacija
{
    public partial class FormLoto : Form
    {
        private Loto loto;
        public FormLoto()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUplati_Click(Object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(textBox1.Text);
            vrijednosti.Add(textBox2.Text);
            vrijednosti.Add(textBox3.Text);
            vrijednosti.Add(textBox4.Text);
            vrijednosti.Add(textBox5.Text);
            vrijednosti.Add(textBox6.Text);
            vrijednosti.Add(textBox7.Text);
            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                buttonOdigraj.Enabled = true;
            }
            else
            {
                buttonOdigraj.Enabled = false;
                MessageBox.Show("Kombinacija uplaćenih brojeva je neispravna.");
            }
        }
        private void btnOdigraj_Click(Object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();

            textBox8.Text = loto.DobitniBrojevi[0].ToString();
            textBox9.Text = loto.DobitniBrojevi[1].ToString();
            textBox10.Text = loto.DobitniBrojevi[2].ToString();
            textBox11.Text = loto.DobitniBrojevi[3].ToString();
            textBox12.Text = loto.DobitniBrojevi[4].ToString();
            textBox13.Text = loto.DobitniBrojevi[5].ToString();
            textBox14.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            labelBroj.Text = brojPogodaka.ToString();
        }
    }
}
