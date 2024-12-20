using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartlar
{
    public class Kart 
    {
        public string Renk;
        public string Sayı;

        public Kart(string renk = null, string sayı = null) 
        {
            Renk = renk;
            Sayı = sayı;
        }
    }

    public class Oyuncu
    {
        public string İsim;
        public List<Kart> EldekiKartlar;

        public Oyuncu(string isim)
        {
            İsim = isim;
            EldekiKartlar = new List<Kart>();
        }

        public void KartEkle(Kart k)
        {
            EldekiKartlar.Add(k);
        }
        public void KartCikart(Kart k)
        {
            EldekiKartlar.Remove(k);
        }
    }

    public class OyunOlustur
    {
        public List<Kart> kartlar;
        public List<Kart> renkdegistirkartlar;
        public List<Kart> renkdegistirdörtkartçekkartlar;
        public List<Kart> cekilenkartlar;
        public List<Kart> atilankartlar;
        public List<Oyuncu> oyuncular;

        public void KartlariHazirla()
        {
            kartlar = new List<Kart>();
            string[] renkler = { "mavi", "kırmızı", "sarı", "yeşil" };
            string[] sayılar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            for (int i = 0; i < renkler.Length; i++) 
            {
                for (int j = 0; j < sayılar.Length; j++)
                {
                    kartlar.Add(new Kart(renkler[i], sayılar[j]));
                }
            }
            for (int i = 0; i < renkler.Length; i++)
            {
                kartlar.Add(new Kart(renkler[i], "İkiKartÇek"));
                kartlar.Add(new Kart(renkler[i], "Döndür"));
                kartlar.Add(new Kart(renkler[i], "Pas"));
            }
            for (int i = 0; i < 4; i++)
            {
                kartlar.Add(new Kart("renksiz", "RenkDeğiştir"));
                kartlar.Add(new Kart("renksiz", "RenkDeğiştirDörtKartÇek"));
            }
        }
        public void RenkDeğiştirKartlarınıHazırla()
        {
            string[] renkler = { "mavi", "kırmızı", "sarı", "yeşil" };
            renkdegistirkartlar = new List<Kart>();
            renkdegistirdörtkartçekkartlar = new List<Kart>();
            for (int i = 0; i < renkler.Length; i++)
            {
                renkdegistirkartlar.Add(new Kart(renkler[i], "RenkDeğiştir"));
                renkdegistirdörtkartçekkartlar.Add(new Kart(renkler[i], "RenkDeğiştirDörtKartÇek"));
            }
        }
        public void KartlariKaristir()
        {
            Random random = new Random();

            for (int i = 0; i < kartlar.Count; i++) 
            {
                int j = random.Next(i+1);

                if (i < kartlar.Count && j < kartlar.Count)
                {
                    Kart temp = kartlar[j];
                    kartlar[j] = kartlar[i];
                    kartlar[i] = temp;
                }
            }
        }
        public void OyunculariHazirla()
        {
            oyuncular = new List<Oyuncu>();

            for (int i = 0; i < 3; i++)
            {
                oyuncular.Add(new Oyuncu($"Yapay Zeka {i+1}"));
            }
            oyuncular.Add(new Oyuncu("Gerçek Oyuncu"));
        }
        public void KartlariDagit()
        {
            int baslangic = 7;

            for (int i = 0; i < oyuncular.Count; i++)
            {
                Oyuncu oyuncu = oyuncular[i];

                for (int j = 0; j < baslangic; j++)
                {
                    Kart cekilenkart = kartlar[0];
                    kartlar.RemoveAt(0);
                    oyuncu.KartEkle(cekilenkart);
                }
            }
        }
        public OyunOlustur()
        {
            atilankartlar = new List<Kart>();
            cekilenkartlar = new List<Kart>();
        }
        public void KartAt(Oyuncu oyuncu, Kart kart)
        {
            oyuncu.KartCikart(kart);
            atilankartlar.Add(kart);
        }
        public void KartCek(Oyuncu oyuncu, Kart kart)
        {
            oyuncu.KartEkle(kart);
            cekilenkartlar.Add(kart);
        }
        public void OrtayaKartAt(Kart kart)
        {
            cekilenkartlar.Add(kart);
        }
    }
}
