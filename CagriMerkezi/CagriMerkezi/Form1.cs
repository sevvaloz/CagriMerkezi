using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagriMerkezi
{
    public partial class cagriMerkeziForm : Form
    {
        public cagriMerkeziForm()
        {
            InitializeComponent();
        }

        //KUYRUKLARI OLUŞTURMA
        TicariMusteriKuyruk tmk = new TicariMusteriKuyruk();
        BireyselMusteriKuyruk bmk = new BireyselMusteriKuyruk();

        //ÇAĞRI LİSTESİ OLUŞTURMA
        List<string> Cagrilar = new List<string>();

        public void cagriMerkeziForm_Load(object sender, EventArgs e)
        {
            TicariCagriTemsilcisi tct1 = new TicariCagriTemsilcisi() { Ad = "meltem" };
            TicariCagriTemsilcisi tct2 = new TicariCagriTemsilcisi() { Ad = "soner" };
            BireyselCagriTemsilcisi bct1 = new BireyselCagriTemsilcisi() { Ad = "mert" };
            BireyselCagriTemsilcisi bct2 = new BireyselCagriTemsilcisi() { Ad = "seda" };
        }

        //ARAMA YAPMA
        public void aramaTicari_Click(object sender, EventArgs e)
        {
            //string zaman = DateTime.Now.ToLongTimeString();

            TicariMusteri tm = new TicariMusteri();         
            Cagri cagri = new Cagri();
            cagri.List_TicariMusteri.Add(tm);

            tmk.ekle(tm.ID.ToString());
            TMlistView.Clear();
            TMlistView.Items.Add(tmk.SirayiGoster());
            MessageBox.Show("Çağrı Temsilcisi ile görüşmek için sıraya eklendiniz. Müşteri ID'niz: " + tm.ID.ToString());
        }

        public void aramaBireysel_Click(object sender, EventArgs e)
        {
            //string zaman = DateTime.Now.ToLongTimeString();

            BireyselMusteri bm = new BireyselMusteri();
            Cagri cagri = new Cagri();
            cagri.List_BireyselMusteri.Add(bm);


            bmk.ekle(bm.ID.ToString());
            BMlistView.Clear();
            BMlistView.Items.Add(bmk.SirayiGoster());
            MessageBox.Show("Çağrı Temsilcisi ile görüşmek için sıraya eklendiniz. Müşteri ID'niz: " + bm.ID.ToString());
        }

        //MÜŞTERİ SIRASI SORGULAMA
        public void siraSorgulama_Click(object sender, EventArgs e)
        {
            string musteriID = musteri_id_text.Text;
            if(Convert.ToInt32(musteriID) <= 500)
            {
                MessageBox.Show(tmk.SiradaArama(musteriID));
            }
            else if(Convert.ToInt32(musteriID) > 500 || Convert.ToInt32(musteriID) <= 1000)
            {
                MessageBox.Show(bmk.SiradaArama(musteriID));
            }
        }

        //ÇAĞRI ATAMA
        public void cagriAtamaTicari_Click(object sender, EventArgs e)
        {
            Cagri cagri = new Cagri();
            cagri.gorusmeBaslangic = DateTime.Now;
            string dt = cagri.gorusmeBaslangic.ToString("T");

            tmk.sil();
            Node _veri = tmk.veri;
            Gorusme_listView.Items.Add(_veri.data);
            Cagrilar.Add(_veri.data);

            TMlistView.Clear();
            TMlistView.Items.Add(tmk.SirayiGoster());
            MessageBox.Show(_veri.data + " id'li müşteri, çağrı temsilcisi ile görüşmede... \n" + dt);

        }

        public void cagriAtamaBireysel_Click(object sender, EventArgs e)
        {
            Cagri cagri = new Cagri();
            cagri.gorusmeBaslangic = DateTime.Now;
            string dt = cagri.gorusmeBaslangic.ToString("T");

            bmk.sil();
            Node _veri = bmk.veri;
            Gorusme_listView.Items.Add(_veri.data);
            Cagrilar.Add(_veri.data);

            BMlistView.Clear();
            BMlistView.Items.Add(bmk.SirayiGoster());
            MessageBox.Show(_veri.data + " id'li müşteri, çağrı temsilcisi ile görüşmede... \n" + dt);
        }

        //ARAMAYI BİTİRME
        public void aramaBitir_Click(object sender, EventArgs e)
        {
            string bitir_id = musteri_id_text.Text;
            foreach(var c in Cagrilar.ToList())
            {
                if(c == bitir_id)
                {
                    Cagrilar.Remove(c);
                }
            }
            Gorusme_listView.Clear();
            foreach (var c in Cagrilar)
            {
                Gorusme_listView.Items.Add(c);
            }
        }

        //NOT İÇİNDE ARANAN KELİMEYİ BULMA
        public void kelimeArama_Click(object sender, EventArgs e)
        {
            int deger = -1;
            string kelime = kelimeText.Text;
            string not = notText.Text;
            string[] Kelimeler = not.Split(' ');

            void KelimeArama(string[] dizi, string arananKelime)
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] == arananKelime)
                    {
                        MessageBox.Show("Aranan kelime bulundu.");
                        deger = 1;
                        break;
                    }
                }
                if(deger == -1)
                {
                    MessageBox.Show("Aranan kelime bulunamadı.");
                }
            }
            KelimeArama(Kelimeler, kelime);
        }
    }
}
