using Kartlar;
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
    public partial class UnoOyun : Form
    {
        private Kartlar.OyunOlustur unoOyunu;
        private WindowsFormsApp1.Form1 anaForm;
        public Kart ortayakart = new Kart();
        public int oyuncuSırası = 3;
        private bool sıraYönü = true;
        public bool kartvar = true;
        private void UnoOyun_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Green;
        }
        public UnoOyun() //Oyunun temel fonksiyonlarını başlatıyor.
        {
            InitializeComponent();
            unoOyunu = new Kartlar.OyunOlustur();
            unoOyunu.KartlariHazirla();
            unoOyunu.KartlariKaristir();
            unoOyunu.OyunculariHazirla();
            unoOyunu.KartlariDagit();
            unoOyunu.RenkDeğiştirKartlarınıHazırla();
            panel2.Hide();
            KartlariGoster();
            ortayaKartAc();
        }
        public void KartlariGoster() //Kullanıcının kartlarını göstermek için kullanılıyor.
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            label1.Text = oyuncu.İsim;

            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            flowLayoutPanel5.Controls.Clear();
            panel1.Controls.Clear();

            Oyuncu gercekoyuncu = unoOyunu.oyuncular[3];

            if (oyuncuSırası == 3)
            {
                if (gercekoyuncu.EldekiKartlar.Count != 2)
                {
                    int i = 0;

                    foreach (Kart kart in gercekoyuncu.EldekiKartlar)
                    {
                        PictureBox kartbuton = new PictureBox();
                        string dosyaYolu = $"{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                        kartbuton.Image = Image.FromFile(dosyaYolu);

                        int kartWidth = 100;
                        int kartHeight = 150;

                        kartbuton.Size = new Size(kartWidth, kartHeight);
                        kartbuton.Location = new Point(i * (kartWidth + 5), 30);
                        i++;

                        kartbuton.MouseEnter += (sender, e) => KartButon_MouseEnter(sender, e, kartbuton);
                        kartbuton.MouseLeave += (sender, e) => KartButon_MouseLeave(sender, e, kartbuton);
                        kartbuton.Click += (sender, e) => KartButon_Click(sender, e, kart, kartbuton);
                        panel1.Controls.Add(kartbuton);
                    }
                }
                else if (gercekoyuncu.EldekiKartlar.Count == 2)
                {
                    int i = 0;

                    foreach (Kart kart in gercekoyuncu.EldekiKartlar)
                    {
                        PictureBox kartbuton = new PictureBox();
                        string dosyaYolu = $"{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                        kartbuton.Image = Image.FromFile(dosyaYolu);

                        Button unobuton = new Button();
                        unobuton.Text = "UNO!";
                        unobuton.Location = new Point(920, 980);
                        unobuton.AutoSize = true;
                        this.Controls.Add(unobuton);

                        int kartWidth = 100;
                        int kartHeight = 150;

                        kartbuton.Size = new Size(kartWidth, kartHeight);
                        kartbuton.Location = new Point(i * (kartWidth + 5), 30);
                        i++;

                        kartbuton.MouseEnter += (sender, e) => KartButon_MouseEnter(sender, e, kartbuton);
                        kartbuton.MouseLeave += (sender, e) => KartButon_MouseLeave(sender, e, kartbuton);
                        kartbuton.Click += (sender, e) => KartButon_Click(sender, e, kart, kartbuton);
                        panel1.Controls.Add(kartbuton);
                    }
                }
            }
            else if (oyuncuSırası != 3)
            {
                int i = 500;
                foreach (Kart kart in gercekoyuncu.EldekiKartlar)
                {
                    PictureBox kartbuton = new PictureBox();
                    string dosyaYolu = $"{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                    kartbuton.Image = Image.FromFile(dosyaYolu);

                    int kartWidth = 110;
                    int kartHeight = 155;

                    kartbuton.Size = new Size(kartWidth, kartHeight);
                    kartbuton.Location = new Point(i, 30);
                    i-=40;

                    kartbuton.MouseEnter += (sender, e) => KartButon_MouseEnter(sender, e, kartbuton);
                    kartbuton.MouseLeave += (sender, e) => KartButon_MouseLeave(sender, e, kartbuton);
                    kartbuton.Click += (sender, e) => KartButon_Click(sender, e, kart, kartbuton);
                    panel1.Controls.Add(kartbuton);
                }
            }
            /*foreach (Kart kart in unoOyunu.oyuncular[0].EldekiKartlar)
            {
                PictureBox kartbuton = new PictureBox();
                string dosyaYolu = $"C:\\Users\\gokan\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                kartbuton.Image = Image.FromFile(dosyaYolu);

                int kartWidth = 110;
                int kartHeight = 155;

                kartbuton.Size = new Size(kartWidth, kartHeight);
                flowLayoutPanel3.Controls.Add(kartbuton);
            }
            foreach (Kart kart in unoOyunu.oyuncular[1].EldekiKartlar)
            {
                PictureBox kartbuton = new PictureBox();
                string dosyaYolu = $"C:\\Users\\gokan\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                kartbuton.Image = Image.FromFile(dosyaYolu);

                int kartWidth = 110;
                int kartHeight = 155;

                kartbuton.Size = new Size(kartWidth, kartHeight);
                flowLayoutPanel4.Controls.Add(kartbuton);
            }
            foreach (Kart kart in unoOyunu.oyuncular[2].EldekiKartlar)
            {
                PictureBox kartbuton = new PictureBox();
                string dosyaYolu = $"C:\\Users\\gokan\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\{kart.Renk.ToLower()}\\{kart.Sayı.ToLower()}.png";
                kartbuton.Image = Image.FromFile(dosyaYolu);

                int kartWidth = 110;
                int kartHeight = 155;

                kartbuton.Size = new Size(kartWidth, kartHeight);
                flowLayoutPanel5.Controls.Add(kartbuton);
            }*/
            int j=400;
            int a = 200;
            foreach (Kart kart in unoOyunu.oyuncular[0].EldekiKartlar)
            {
                PictureBox kartbuton = new PictureBox();
                kartbuton.Image = Image.FromFile("renksiz\\uno.png");

                int kartWidth = 110;
                int kartHeight = 200;

                kartbuton.Size = new Size(kartWidth, kartHeight);
                kartbuton.Location = new Point(j,a);
                j-=40;
                a-=10;
                panel3.Controls.Add(kartbuton);
            }

        }
        public void KartButon_MouseEnter(object sender, EventArgs e, PictureBox kartbuton) //Kartların üstüne mouse gelince işleve giriyor.
        {
            kartbuton.Top -= 30;
        }
        public void KartButon_MouseLeave(object sender, EventArgs e, PictureBox kartbuton) //Mouse kartların üstünden çekilince işleve giriyor.
        {
            kartbuton.Top += 30;
        }
        public void ortayaKartAc() //Oyuna başlamak için ortaya kart açıyor.
        {
            for (int i = 0; i < unoOyunu.kartlar.Count; i++)
            {
                if (unoOyunu.kartlar[i].Renk != "renksiz")
                {
                    ortayakart = unoOyunu.kartlar[i];
                    unoOyunu.kartlar.RemoveAt(0);
                    unoOyunu.OrtayaKartAt(ortayakart);
                }
            }
            ortadakikart.Image = Image.FromFile($"C:\\Users\\gokan\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\{ortayakart.Renk.ToLower()}\\{ortayakart.Sayı.ToLower()}.png");
        }
        public void Sıraİşlemleri() // Kart atıldıktan sonra sıra işlemleri gerçekleşiyor.
        {
            if (sıraYönü == true)
            {
                oyuncuSırası = (oyuncuSırası + 1) % 4;
            }
            else if (sıraYönü == false)
            {
                if (oyuncuSırası == 0)
                {
                    oyuncuSırası = 3;
                }
                else
                {
                    oyuncuSırası = (oyuncuSırası - 1) % 4;
                }
            }
            KartlariGoster();
        }
        public void kartcekbuton_Click_1(object sender, EventArgs e) //Kart çek butonuna basınca kart veriyor.
        {
            if (oyuncuSırası == 3)
            {
                KartÇek();
                YapayZekayaKartAttırma();
            }
        }
        public void KartÇek() //Ortadan kart çekme işlemini yapar.
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            Kart kart = unoOyunu.kartlar[0];
            unoOyunu.KartCek(oyuncu, kart);
            Sıraİşlemleri();
            KartlariGoster();
        }
        public void CezalıKartCek(int a) //Cezalı kartları vermek için kullanılıyor.
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            for (int i = 0; i < a; i++)
            {
                Kart kart = unoOyunu.kartlar[0];
                unoOyunu.kartlar.RemoveAt(0);
                unoOyunu.KartCek(oyuncu, kart);
            }
            Sıraİşlemleri();
        }
        public void KartAtma(Kart kart) //Ortaya kart atma işlemini yapar.
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            unoOyunu.KartAt(oyuncu, kart);
            ortayakart = kart;
            ortadakikart.Image = Image.FromFile($"{ortayakart.Renk.ToLower()}\\{ortayakart.Sayı.ToLower()}.png");
            KartlariGoster();
        }
        public void Titre(PictureBox kartfoto) //Titreme eylemini gerçekleştirir.
        {
            Random random = new Random();
            int titremeMiktarX = 5;
            int titremeMiktarY = 5;

            for (int i = 0; i < 10; i++)
            {
                int orjinalLeft = kartfoto.Left;
                int orjinalTop = kartfoto.Top;
                kartfoto.Left += random.Next(-titremeMiktarX, titremeMiktarX);
                kartfoto.Top += random.Next(-titremeMiktarY, titremeMiktarY);
                kartfoto.Left = orjinalLeft;
                kartfoto.Top = orjinalTop;
            }
        }
        public void KartÇekCeza(int sayı)//İki Kart Çekme İşlemini Yapar.
        {
            if (sıraYönü == true)
            {
                switch (oyuncuSırası)
                {
                    case 0:
                        oyuncuSırası = 1;
                        CezalıKartCek(sayı);
                        break;
                    case 1:
                        oyuncuSırası = 2;
                        CezalıKartCek(sayı);
                        break;
                    case 2:
                        oyuncuSırası = 3;
                        CezalıKartCek(sayı);
                        break;
                    case 3:
                        oyuncuSırası = 0;
                        CezalıKartCek(sayı);
                        break;
                    default:
                        break;
                }
            }
            else if (sıraYönü == false)
            {
                switch (oyuncuSırası)
                {
                    case 0:
                        oyuncuSırası = 3;
                        CezalıKartCek(sayı);
                        break;
                    case 1:
                        oyuncuSırası = 0;
                        CezalıKartCek(sayı);
                        break;
                    case 2:
                        oyuncuSırası = 1;
                        CezalıKartCek(sayı);
                        break;
                    case 3:
                        oyuncuSırası = 2;
                        CezalıKartCek(sayı);
                        break;
                    default:
                        break;
                }
            }
        }
        public void Döndür(Kart kart)//Döndürme İşlemini Yapar.
        {
            if (sıraYönü == true)
            {
                sıraYönü = false;
                KartAtma(kart);
                Sıraİşlemleri();
            }
            else if (sıraYönü == false)
            {
                sıraYönü = true;
                KartAtma(kart);
                Sıraİşlemleri();
            }
        }
        public void Pas(Kart kart)//Pas İşlemini Yapar.
        {
            KartAtma(kart);
            if (sıraYönü == true)
            {
                switch (oyuncuSırası)
                {
                    case 0:
                        oyuncuSırası = 1;
                        break;
                    case 1:
                        oyuncuSırası = 2;
                        break;
                    case 2:
                        oyuncuSırası = 3;
                        break;
                    case 3:
                        oyuncuSırası = 0;
                        break;
                    default:
                        break;
                }
            }
            else if (sıraYönü == false)
            {
                switch (oyuncuSırası)
                {
                    case 0:
                        oyuncuSırası = 3;
                        break;
                    case 1:
                        oyuncuSırası = 0;
                        break;
                    case 2:
                        oyuncuSırası = 1;
                        break;
                    case 3:
                        oyuncuSırası = 2;
                        break;
                    default:
                        break;
                }
            }
            Sıraİşlemleri();
        }
        public void RenkSeçme(object yenisender, EventArgs yenie, Kart kart, Kart renkkart)
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            oyuncu.KartCikart(kart);
            unoOyunu.KartAt(oyuncu, kart);
            kart.Renk = renkkart.Renk;
            ortayakart = kart;

            ortadakikart.Image = Image.FromFile($"{ortayakart.Renk.ToLower()}\\{ortayakart.Sayı.ToLower()}.png");

            Sıraİşlemleri();
            KartlariGoster();
            YapayZekayaKartAttırma();

            panel2.Hide();
        }
        public void RenkSeçmeCezalı(object yenisender, EventArgs yenie, Kart kart, Kart renkkart)
        {
            Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
            oyuncu.KartCikart(kart);
            unoOyunu.KartAt(oyuncu, kart);
            kart.Renk = renkkart.Renk;
            ortayakart = kart;

            ortadakikart.Image = Image.FromFile($"{ortayakart.Renk.ToLower()}\\{ortayakart.Sayı.ToLower()}.png");

            KartÇekCeza(4);
            KartlariGoster();
            YapayZekayaKartAttırma();
            panel2.Hide();
        }
        public void KartButon_Click(object sender, EventArgs e, Kart kart, PictureBox kartfoto) //Kartlara Tıklanınca Yapılacak İşlemler.
        {
            if (oyuncuSırası == 3)
            {
                if (kart.Renk == ortayakart.Renk || kart.Sayı == ortayakart.Sayı)
                {
                    if (kart.Sayı == "İkiKartÇek")
                    {
                        KartAtma(kart);
                        KartÇekCeza(2);
                    }
                    else if (kart.Sayı == "Döndür")
                    {
                        Döndür(kart);
                    }
                    else if (kart.Sayı == "Pas")
                    {
                        Pas(kart);
                    }
                    else
                    {
                        KartAtma(kart);
                        Sıraİşlemleri();
                    }
                }
                else if (kart.Renk == "renksiz" && kart.Sayı == "RenkDeğiştir")
                {
                    panel2.Controls.Clear();
                    panel2.Show();

                    foreach (Kart renkkart in unoOyunu.renkdegistirkartlar)
                    {
                        PictureBox renkbuton = new PictureBox();
                        string dosyayolu = $"{renkkart.Sayı.ToLower()}\\{renkkart.Renk.ToLower()}.png";
                        renkbuton.Image = Image.FromFile(dosyayolu);

                        int kartWidth = 110;
                        int kartHeight = 155;
                        renkbuton.Size = new Size(kartWidth, kartHeight);

                        object yeniSender = new object();

                        renkbuton.Click += (yenisender, yenie) => RenkSeçme(yenisender, yenie, kart, renkkart);


                        panel2.Controls.Add(renkbuton);
                    }
                }
                else if (kart.Renk == "renksiz" && kart.Sayı == "RenkDeğiştirDörtKartÇek")
                {
                    panel2.Controls.Clear();
                    panel2.Show();

                    foreach (Kart renkkart in unoOyunu.renkdegistirdörtkartçekkartlar)
                    {
                        PictureBox renkbuton = new PictureBox();
                        string dosyayolu = $"{renkkart.Sayı.ToLower()}\\{renkkart.Renk.ToLower()}.png";
                        renkbuton.Image = Image.FromFile(dosyayolu);

                        int kartWidth = 110;
                        int kartHeight = 155;
                        renkbuton.Size = new Size(kartWidth, kartHeight);

                        object yeniSender = new object();

                        renkbuton.Click += (yenisender, yenie) => RenkSeçmeCezalı(yenisender, yenie, kart, renkkart);

                        panel2.Controls.Add(renkbuton);
                    }
                }
                else
                {
                    Titre(kartfoto);
                }
                YapayZekayaKartAttırma();
            }
            else
            {
                Titre(kartfoto);
            }
        }

        public void YapayZekayaKartAttırma()
        {
            if (oyuncuSırası != 3)
            {
                KartKontrol();

                if (kartvar == false)
                {
                    KartÇek();
                    kartvar = true;
                }
            }
        }

        public async void KartKontrol()
        {
            Oyuncu yapayzeka = unoOyunu.oyuncular[oyuncuSırası];

            await Task.Delay(3000);

            for (int i = 0; i < yapayzeka.EldekiKartlar.Count; i++)
            {
                Kart kart = yapayzeka.EldekiKartlar[i];
                if (kart.Renk == ortayakart.Renk || kart.Sayı == ortayakart.Sayı)
                {
                    if (kart.Sayı == "Döndür")
                    {
                        if (sıraYönü == true)
                        {
                            sıraYönü = false;
                        }
                        else if (sıraYönü == false)
                        {
                            sıraYönü = true;
                        }
                        KartAtma(kart);
                        Sıraİşlemleri();
                    }
                    else if (kart.Sayı == "Pas")
                    {
                        if (sıraYönü == true)
                        {
                            oyuncuSırası+=2;
                        }
                        else if (sıraYönü == false)
                        {
                            if (oyuncuSırası == 0)
                            {
                                oyuncuSırası = 2;
                            }
                            else if (oyuncuSırası == 1)
                            {
                                oyuncuSırası = 3;
                            }
                            else
                            {
                                oyuncuSırası -=2;
                            }
                        }
                        KartAtma(kart);
                    }
                    else if (kart.Sayı == "İkiKartÇek")
                    {
                        if (sıraYönü == true)
                        {
                            oyuncuSırası++;
                            CezalıKartCek(2);
                        }
                        else if (sıraYönü == false)
                        {
                            oyuncuSırası--;
                            CezalıKartCek(2);
                        }
                        KartAtma(kart);
                        Sıraİşlemleri();
                    }
                    else if (kart.Renk == ortayakart.Renk || kart.Sayı == ortayakart.Sayı)
                    {
                        ortayakart = kart;
                        unoOyunu.KartAt(yapayzeka, kart);
                        KartAtma(kart);
                        kartvar = true;
                        break;
                    }
                }
                else if (kart.Renk == "renksiz" && kart.Sayı == "RenkDeğiştir")
                {
                    Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
                    label1.Text = $"Sıra: {oyuncuSırası+1}";
                    oyuncu.KartCikart(kart);
                    unoOyunu.KartAt(oyuncu, kart);


                    string[] renkler = { "mavi", "kırmızı", "sarı", "yeşil" };
                    Random random = new Random();
                    int ran = random.Next(renkler.Length);
                    unoOyunu.KartAt(yapayzeka, kart);
                    kart.Renk = renkler[ran];
                    ortayakart = kart;
                    kartvar = true;

                    KartAtma(kart);
                    Sıraİşlemleri();
                    KartlariGoster();

                    break;
                }
                else if (kart.Renk == "renksiz" && kart.Sayı == "RenkDeğiştirDörtKartÇek")
                {
                    Oyuncu oyuncu = unoOyunu.oyuncular[oyuncuSırası];
                    label1.Text = $"Sıra: {oyuncuSırası+1}";
                    oyuncu.KartCikart(kart);
                    unoOyunu.KartAt(oyuncu, kart);


                    string[] renkler = { "mavi", "kırmızı", "sarı", "yeşil" };
                    Random random = new Random();
                    int ran = random.Next(renkler.Length);
                    unoOyunu.KartAt(yapayzeka, kart);
                    kart.Renk = renkler[ran];
                    ortayakart = kart;
                    kartvar = true;

                    KartAtma(kart);
                    KartlariGoster();
                    oyuncuSırası++;
                    CezalıKartCek(4);
                    Sıraİşlemleri();
                    break;
                }
                else
                {
                    kartvar = false;
                }
            }
            YapayZekayaKartAttırma();
        }
    }
}