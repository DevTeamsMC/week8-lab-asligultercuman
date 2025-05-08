using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class AyarlarForm : Form
    {
        public string zorluk;
        public string gorsel;
        public string soruTuru;
        public AyarlarForm(int sure, string zorluk, string gorsel,string soruTuru)
        {
            this.zorluk = zorluk;
            this.gorsel = gorsel;
            this.soruTuru = soruTuru;
            InitializeComponent();
        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        { 
            int sure = int.Parse(txtSure.Text);
         
            Form1 form = new Form1(sure, zorluk, gorsel, soruTuru);
            form.Show();
            this.Hide();
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            zorluk = cmbZorluk.SelectedIndex.ToString();
            gorsel = cmbGorsel.SelectedIndex.ToString();
            soruTuru = cmbSoruTuru.SelectedIndex.ToString();
        }
    }
}
