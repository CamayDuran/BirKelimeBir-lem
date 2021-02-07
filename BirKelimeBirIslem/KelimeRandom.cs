using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirIslem
{
    public partial class KelimeRandom : Form
    {
        public KelimeRandom()
        {
            InitializeComponent();
        }

        private void KelimeRandom_Load(object sender, EventArgs e)
        {

        }
        public static int rastgeleSayiUret(int baslangic, int bitis)
        {
            Random rnd = new Random();
            return rnd.Next(baslangic, bitis);
        }   
            public void button1_Click(object sender, EventArgs e)
            {
                int charKodu = rastgeleSayiUret(97,123);
                lbl1.Text = Convert.ToChar(charKodu).ToString();
                int charKodu2 = rastgeleSayiUret(97, 123);
                lbl2.Text = Convert.ToChar(charKodu2).ToString();
                int charKodu3 = rastgeleSayiUret(97, 123);
                lbl3.Text = Convert.ToChar(charKodu3).ToString();
                int charKodu4 = rastgeleSayiUret(97, 123);
                lbl4.Text = Convert.ToChar(charKodu4).ToString();
                int charKodu5 = rastgeleSayiUret(97, 123);
                lbl5.Text = Convert.ToChar(charKodu5).ToString();
                int charKodu6 = rastgeleSayiUret(97, 123);
                lbl6.Text = Convert.ToChar(charKodu6).ToString();
                int charKodu7 = rastgeleSayiUret(97, 123);
                lbl7.Text = Convert.ToChar(charKodu7).ToString();
                int charKodu8 = rastgeleSayiUret(97, 123);
                lbl8.Text = Convert.ToChar(charKodu8).ToString();
                string[] Harf = { Convert.ToChar(charKodu).ToString(), Convert.ToChar(charKodu2).ToString(), Convert.ToChar(charKodu3).ToString(), Convert.ToChar(charKodu4).ToString(), Convert.ToChar(charKodu5).ToString(), Convert.ToChar(charKodu6).ToString(), Convert.ToChar(charKodu7).ToString(), Convert.ToChar(charKodu8).ToString() };
                string[] BonusKelime = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
                string DosyaYolu = @"C:\EminHocaOdev\metinbelgesi.txt";
                string[] metin = File.ReadAllLines(DosyaYolu, Encoding.GetEncoding("windows-1254"));
                for (int i = 0; i < 1000; i++)
                {
                    for (int y = 0; y < 29; y++)
                    {
                        if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 15 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 11 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 11 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 11 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 11 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[7] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 11 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[7] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[0] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[6] + Harf[5] + Harf[3] + Harf[4] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + BonusKelime[y] + Harf[6] + Harf[5] + Harf[3] + Harf[4] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 9 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[0] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[6] + Harf[5] + Harf[1] + Harf[2] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[6] + Harf[5] + Harf[3] + Harf[4] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[7] + Harf[6] + Harf[5] + Harf[3] + Harf[4] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[0] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[0] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[0] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[0] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[1] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[1] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[1] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 7 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[0] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[0] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[0] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[0] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[1] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[1] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[1] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[2] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 5 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + BonusKelime[y] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + BonusKelime[y] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 4 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[0] + Harf[1] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[1] + Harf[2] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[2] + Harf[3] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[5])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[3] + Harf[4] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[6])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[4] + Harf[5] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[5] + Harf[6] + Harf[7])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[0])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[1])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[2])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[3])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                        else if (metin[i] == Harf[6] + Harf[7] + Harf[4])
                            listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[1])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[2])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[3])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[4])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[5])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[0] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[2])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[3])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[4])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[5])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[1] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[3])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[4])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[5])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[2] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[4])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[5])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[3] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[5])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[4] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[6])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[5] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                    else if (metin[i] == Harf[6] + BonusKelime[y] + Harf[7])
                        listBox1.Items.Add(metin[i] + "\n 3 Puan kazandınız...");
                }
                }
            }
    }
}
