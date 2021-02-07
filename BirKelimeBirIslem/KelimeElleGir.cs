using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace BirKelimeBirIslem
{
    public partial class KelimeElleGir : Form
    {
        public KelimeElleGir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Harf = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text };
            string[] BonusKelime = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
            string DosyaYolu = @"C:\EminHocaOdev\metinbelgesi.txt";
            string[] metin = File.ReadAllLines(DosyaYolu, Encoding.GetEncoding("windows-1254"));
            for (int i = 0; i < 533; i++)
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

        private void KelimeElleGir_Load(object sender, EventArgs e)
        {

        }
       
    }
}
