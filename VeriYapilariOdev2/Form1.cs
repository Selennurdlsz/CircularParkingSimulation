using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VeriYapilariOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch sw = new Stopwatch();
        ZeminKatQueue zk = new ZeminKatQueue(15);
        BodrumKatStack bk = new BodrumKatStack(15);
        IkinciKatList ik = new IkinciKatList();
        public int sayac = 0;
        public void ArabaEkle()
        {
            sw.Start();
            sayac++;
            if (sayac % 2 == 0)
            {
                object temp = "";
                temp = bk.Pop();
                if(temp.ToString()=="Mavi1")
                    MessageBox.Show("BODRUM KATTA KALAN SON ARABA:" + temp);
                MessageBox.Show("BODRUM KATTAN ÇIKAN VE ZEMİN KATA EKLENEN ARABA:" + temp);
                Araba a1 = new Araba();
                a1.ArabaRengi = temp.ToString();
                zk.ZeminKatArabaEkle(a1);
                zk.Insert(a1);
            }
            else
            {
                object temp = "";
                temp = ik.Remove();
                if (temp.ToString() == "Beyaz15")
                    MessageBox.Show("İKİNCİ KATTA KALAN SON ARABA:" + temp);
                MessageBox.Show("İKİNCİ KATTAN ÇIKAN VE ZEMİN KATA EKLENEN ARABA:" + temp);
                Araba a1 = new Araba();
                a1.ArabaRengi = temp.ToString();
                zk.ZeminKatArabaEkle(a1);
                zk.Insert(a1);
            }
            MessageBox.Show("Bilgisayarın Diğer Katlardan Zemin Kata Araba Ekleme Süresi:" + sw.Elapsed.ToString());
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            sw.Start();
            for (int i = 0; i < 15; i++)
            {
                Araba a = new Araba();
                a.ArabaRengi = "Yesil " + Convert.ToInt16(i + 1);
                Araba a1 = new Araba();
                a1.ArabaRengi = "Mavi " + Convert.ToInt16(i + 1);
                Araba a2 = new Araba();
                a2.ArabaRengi = "Beyaz " + Convert.ToInt16(i + 1);
                
                zk.ZeminKatArabaEkle(a);
                zk.Insert(a);
                bk.BodrumKatArabaEkle(a1);
                bk.Push(a1);
                ik.IkinciKatArabaEkle(a2);
                ik.InsertLast(a2);
            }
            MessageBox.Show("ZEMİN KATTAKİ ARABALAR"+zk.getElements()+ "\nBODRUM KATTAKİ ARABALAR" + bk.getElements()+"\nİKİNCİ KATTAKİ ARABALAR"+ik.getElements());
            MessageBox.Show("Bilgisayarın Zemin,Bodrum ve İkinci Kata Araba Ekleme Süresi:" + sw.Elapsed.ToString());
            btnArabaCikar.Visible = true; 
            
        }
        
        private void btnArabaCikar_Click(object sender, EventArgs e)
        {
            sw.Start();
            MessageBox.Show("OTOPARKTAN ÇIKAN ARABA:" + zk.Remove());
            if(sayac<30)
              ArabaEkle();
            MessageBox.Show("BİLİGİSAYARIN Otoparktan Araba Çıkarma Süresi:" + sw.Elapsed.ToString());
            MessageBox.Show("ZEMİN KATTAKİ ARABALAR" + zk.getElements() + "\nBODRUM KATTAKİ ARABALAR" + bk.getElements() + "\nİKİNCİ KATTAKİ ARABALAR" + ik.getElements());
        }
    }
}
