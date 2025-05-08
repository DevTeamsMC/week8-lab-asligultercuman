using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form2 : Form
    {
        // TARİH
        string[] wordListTarihKolay = { "ATATÜRK", "FATİH", "1923", "ANKARA", "1938", "SELANİK", "AKİF" };
        string[] soruListTarihKolay = {
        "Türkiye'nin ilk cumhurbaşkanı kimdir?",
        "İstanbul’u fetheden padişah kimdir?",
        "Türkiye Cumhuriyeti ne zaman kuruldu?",
        "Türkiye’nin başkenti neresidir?",
        "Atatürk hangi yıl vefat etti?",
        "Atatürk’ün doğduğu şehir neresidir?",
        "İstiklal Marşı'nın yazarı kimdir?"
        };

           
        string[] wordListTarihOrta = { "MALAZGİRT", "BURSA", "KONYA", "MOSKOVA", "İNÖNÜ" };
        string[] soruListTarihOrta = {
        "1071’de yapılan büyük savaş hangisidir?",
        "Osmanlı’nın ilk başkenti neresidir?",
        "Anadolu Selçuklu Devleti’nin başkenti neresidir?",
        "1921’de Sovyetler’le imzalanan antlaşma nedir?",
        "Atatürk’ten sonra cumhurbaşkanı kim olmuştur?"
        };

        string[] wordListTarihZor = { "VIYANA", "SENED", "ANKARA", "SATI", "SOKULLU" };
        string[] soruListTarihZor = {
        "1683’te kuşatılan Avrupa şehri hangisidir?",
        "Osmanlı’da padişah yetkilerini sınırlayan belge nedir?",
        "1402 yılında yapılan Osmanlı-Timur savaşı hangi şehirde olmuştur?",
        "Türkiye’nin ilk kadın milletvekili kimdir?",
        "Duraklama devri hangi sadrazam döneminde başlamıştır?"
        };

        // COĞRAFYA
        string[] wordListCografyaKolay = { "ASYA", "AFRİKA", "KIZILDENİZ", "DÜNYA", "ANADOLU" };
        string[] soruListCografyaKolay = {
        "Türkiye’nin bulunduğu kıta nedir?",
        "En büyük çöl hangi kıtadadır?",
        "Afrika ile Asya’yı ayıran deniz nedir?",
        "Üzerinde yaşadığımız gezegen nedir?",
        "Türkiye’nin Asya’daki kısmına ne ad verilir?"
        };

        string[] wordListCografyaOrta = { "MARMARA", "EVEREST", "EKVATOR", "GÖL", "DELTA" };
        string[] soruListCografyaOrta = {
        "İstanbul’un içinde bulunduğu bölge nedir?",
        "Dünyanın en yüksek dağı nedir?",
        "Dünyayı ortadan bölen hayali çizgi nedir?",
        "Denizden tamamen kopmuş büyük su birikintisi nedir?",
        "Akarsuların denize ulaştığı verimli alana ne denir?"
        };

        string[] wordListCografyaZor = { "BATI", "TAIGA", "FAUNA", "LITOSFER", "RÜZGAR" };
        string[] soruListCografyaZor = {
        "Güneşin battığı yön nedir?",
        "Sibirya ormanlarına verilen ad nedir?",
        "Belirli bir bölgede yaşayan hayvan topluluğu nedir?",
        "Yer kabuğunun diğer adı nedir?",
        "Yüksek basınçtan alçak basınca hareket eden hava akımı nedir?"
        };

        // MATEMATİK
        string[] wordListMatematikKolay = { "DÖRT", "YÜZ", "ÇARPMA", "ON", "SIFIR" };
        string[] soruListMatematikKolay = {
        "İki artı iki kaç eder?",
        "10 çarpı 10 sonucu nedir?",
        "Toplama, çıkarma, bölme dışında kalan işlem nedir?",
        "Beş artı beş kaç eder?",
        "Hiçbir değer olmayan rakam nedir?"
        };

        string[] wordListMatematikOrta = { "KARE", "FAKTÖRİYEL", "ASAL", "ÜS", "ORAN" };
        string[] soruListMatematikOrta = {
        "Tüm kenarları eşit dörtgen nedir?",
        "n! şeklinde gösterilen işlem nedir?",
        "Sadece bire ve kendisine bölünen sayı türü nedir?",
        "Bir sayının kendisiyle tekrarlı çarpımı hangi işlemle gösterilir?",
        "İki büyüklüğün birbirine bölünmesiyle bulunan değere ne denir?"
        };

        string[] wordListMatematikZor = { "İRRASYONEL", "LOGARİTMA", "İNTEGRAL", "LİMİT", "DİFERANSİYEL" };
        string[] soruListMatematikZor = {
        "Kök içinde ifade edilen, ondalık olarak bitmeyen sayı türü nedir?",
        "Log tabanında kullanılan matematiksel işlem nedir?",
        "Alan hesaplamasında kullanılan ileri düzey işlem nedir?",
        "Fonksiyonların uç değerlerini bulmada kullanılan hesaplama nedir?",
        "Türev ve integralin temelini oluşturan matematik dalı nedir?"
        };

        string word = "";
        int score = 100;
        int wrongGuessCount = 0;
        List<char> wrongGuesses = new List<char>();
        char[] displayedWord;
        bool gameEnded = false;
        int randomIndex = 0;

        public int sure;
        public string zorluk;
        public string gorsel;
        public string soruTuru;

        public Form2(int sure, string zorluk, string gorsel, string soruTuru)
        {
            this.sure = sure*1000;
            this.zorluk = zorluk;
            this.gorsel = gorsel;
            this.soruTuru = soruTuru;

            InitializeComponent();  

            // Timer ayarları
            timer1.Interval = 1000; // 1 saniye
            timer1.Tick += (s, e) =>
            {
                if (!gameEnded)
                {
                    sure--;
                    labelTimer.Text = $"Kalan Süre: {sure}s";

                    if (sure <= 0)
                    {
                        timer1.Stop();
                        gameEnded = true;
                        MessageBox.Show($"Süre bitti! Doğru kelime: {word}", "Zaman Doldu");
                        this.Close();
                    }
                }
            };
            timer1.Start();
        }

        private void UpdateDisplay()
        {
            label3.Text = string.Join(" ", displayedWord);
            if (!new string(displayedWord).Contains('_'))
            {
                gameEnded = true;
                timer1.Stop();
                this.BackColor = Color.Green;
                MessageBox.Show("Tebrikler! Kazandınız!", "Oyun Bitti");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameEnded) return;
            if (string.IsNullOrWhiteSpace(input.Text)) return;

            char guess = char.ToUpper(input.Text[0]);
            input.Clear();

            if (wrongGuesses.Contains(guess) || new string(displayedWord).Contains(guess))
            {
                MessageBox.Show("Bu harfi zaten denediniz!", "Uyarı");
                return;
            }

            if (word.Contains(guess))
            {
                for (int i = 0; i < word.Length; i++)
                    if (word[i] == guess)
                        displayedWord[i] = guess;

                UpdateDisplay();
            }
            else
            {
                wrongGuesses.Add(guess);
                wrongGuessCount++;
                score = Math.Max(0, score - 10);

                labelWrong.Text = "Yanlış Tahminler: " + string.Join(", ", wrongGuesses);
                label2.Text = score.ToString();
                
                // hata oldugunda farklı gorseller icin degisim
                string path = "";
                if (gorsel == "Çiçek")
                    path = $"cicek-0{wrongGuessCount}.jpg";
                else if (gorsel == "Balon Patlat")
                    path = $"balon-0{wrongGuessCount}.jpg";
                else // varsayılan olarak adam
                    path = $"man-0{wrongGuessCount}.jpg";
                pictureBox1.Image = Image.FromFile(path);

                if (wrongGuessCount >= 10)
                {
                    gameEnded = true;
                    timer1.Stop();
                    this.BackColor = Color.Red;
                    MessageBox.Show($"Kaybettiniz! Kelime: {word}", "Oyun Bitti");
                }
            }
        }

        private void buttonIpucu_Click(object sender, EventArgs e)
        {   
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oyundan çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            score = 100;
            wrongGuessCount = 0;
            wrongGuesses.Clear();
            gameEnded = false;
            sure = 60;
            this.BackColor = SystemColors.Control;

            if (soruTuru == "Matematik" && zorluk == "Kolay")
                lblSoru.Text = soruListMatematikKolay[randomIndex];
            else if (soruTuru == "Matematik" && zorluk == "Orta")
                lblSoru.Text = soruListMatematikOrta[randomIndex];
            else if (soruTuru == "Matematik" && zorluk == "Zor")
                lblSoru.Text = soruListMatematikZor[randomIndex];
            else if (soruTuru == "Tarih" && zorluk == "Kolay")
                lblSoru.Text = soruListTarihKolay[randomIndex];
            else if (soruTuru == "Tarih" && zorluk == "Orta")
                lblSoru.Text = soruListTarihOrta[randomIndex];
            else if (soruTuru == "Tarih" && zorluk == "Zor")
                lblSoru.Text = soruListTarihZor[randomIndex];
            else if (soruTuru == "Coğrafya" && zorluk == "Kolay")
                lblSoru.Text = soruListCografyaKolay[randomIndex];
            else if (soruTuru == "Coğrafya" && zorluk == "Orta")
                lblSoru.Text = soruListCografyaOrta[randomIndex];
            else if (soruTuru == "Coğrafya" && zorluk == "Zor")
                lblSoru.Text = soruListCografyaZor[randomIndex];

            Random r = new Random();

            if (soruTuru == "Matematik" && zorluk == "Kolay")
            {
                randomIndex = r.Next(0, wordListMatematikKolay.Length);
                word = wordListMatematikKolay[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Matematik" && zorluk == "Orta")
            {
                randomIndex = r.Next(0, wordListMatematikOrta.Length);
                word = wordListMatematikOrta[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Matematik" && zorluk == "Zor")
            {
                randomIndex = r.Next(0, wordListMatematikZor.Length);
                word = wordListMatematikZor[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Coğrafya" && zorluk == "Kolay")
            {
                randomIndex = r.Next(0, wordListCografyaKolay.Length);
                word = wordListCografyaKolay[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Coğrafya" && zorluk == "Orta")
            {
                randomIndex = r.Next(0, wordListCografyaOrta.Length);
                word = wordListCografyaOrta[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Coğrafya" && zorluk == "Zor")
            {
                randomIndex = r.Next(0, wordListCografyaZor.Length);
                word = wordListCografyaZor[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Tarih" && zorluk == "Kolay")
            {
                randomIndex = r.Next(0, wordListTarihKolay.Length);
                word = wordListTarihKolay[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Tarih" && zorluk == "Orta")
            {
                randomIndex = r.Next(0, wordListTarihOrta.Length);
                word = wordListTarihOrta[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }
            else if (soruTuru == "Tarih" && zorluk == "Zor")
            {
                randomIndex = r.Next(0, wordListTarihZor.Length);
                word = wordListTarihZor[randomIndex];
                displayedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                    displayedWord[i] = '_';
            }


            // gorsel baslatma
            if (gorsel == "Çiçek") pictureBox1.Image = Image.FromFile("cicek-01.jpg");
            else if (gorsel == "Balon Patlat") pictureBox1.Image = Image.FromFile("balon-01.jpg");
            else pictureBox1.Image = Image.FromFile("man-01.jpg");

            // kelime uzunlugu kadar cizgi koyma
            
         
            labelWrong.Text = "Yanlış Tahminler: ";
            label2.Text = score.ToString();
            labelLength.Text = $"Kelime Uzunluğu: {word.Length}";
            lblSoru.Text = "";
            

            lblBilgiler.Text = $"Süre: {sure} saniye - Kategori: {soruTuru} - Seviye: {zorluk}";

        }
    }
}