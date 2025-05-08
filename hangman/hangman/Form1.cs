namespace hangman
{
    public partial class Form1 : Form
    {
        public int sure;
        public string zorluk;
        public string gorsel;
        public string soruTuru;

        public Form1(int sure = 30, string zorluk="", string gorsel="", string soruTuru="")//30 saniye nasýl gosterilir
        {
            this.sure = sure;
            this. zorluk = zorluk;
            this. gorsel = gorsel;
            this.soruTuru = soruTuru;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(sure, zorluk, gorsel, soruTuru);
            form2.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm form = new AyarlarForm(sure, zorluk, gorsel, soruTuru);
            form.Show();
            this.Hide();
        }
    }
}