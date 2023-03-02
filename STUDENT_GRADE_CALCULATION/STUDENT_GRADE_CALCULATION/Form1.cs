using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_GRADE_CALCULATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int not1;
        int not2;
        int VİZE;
        int FİNAL;
        int Ortalama;

        public int PuanOrtalamasi(int VİZE, int FİNAL)
        {

            not1 = Convert.ToInt16(Txtvize.Text);
            not2 = Convert.ToInt16(Txtfinal.Text);
            VİZE = (not1 * 40) / 100;
            FİNAL = (not2 * 60) / 100;
            return Ortalama = VİZE + FİNAL;
        }

        
     
        private void Btnekle_Click(object sender, EventArgs e)
        {

                 PuanOrtalamasi(VİZE, FİNAL);
                StreamWriter sr = File.AppendText("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\Tümöğrenciler.txt");
                sr.Write(Txtadsoyad.Text +" ");
                sr.Write(Txtvize.Text +" ");
                sr.Write(Txtfinal.Text+"\n");
                sr.Close();
                
            if (Ortalama >= 50)
                  {
                    StreamWriter sr2 = File.AppendText("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\geçenler.txt");
                    sr2.Write(Txtadsoyad.Text +" ");
                    sr2.Write(Txtvize.Text +" ");
                    sr2.Write(Txtfinal.Text+"\n");
                    sr2.Close();
                     MessageBox.Show("öğrenci bilgeleri kaydoldu. öğrenci geçmiştir");
 
                   }
            else
            {
                StreamWriter sr3 = File.AppendText("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\kalanlar.txt" );
                sr3.Write(Txtadsoyad.Text +" ");
                sr3.Write(Txtvize.Text +" ");
                sr3.Write(Txtfinal.Text+"\n");
                sr3.Close();
                MessageBox.Show("öğrenci bilgeleri kaydoldu.öğrenci kalmıştır.");
            }
  
           
        }

        private void Btnhesapla_Click(object sender, EventArgs e)
        {
            PuanOrtalamasi(VİZE, FİNAL);
            Lblortalama.Text =Ortalama.ToString();
        }

        private void Btngecenler_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\geçenler.txt");
            while (sr.EndOfStream == false) //endofstrem=dosya sonu karakteri demektir.
            {
                string oku = sr.ReadLine();
               richTextBox1.Text += oku + "\n";
            }

            sr.Close();
        }

        private void Btnkalanlar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\kalanlar.txt");
            while (sr.EndOfStream == false) //endofstrem=dosya sonu karakteri demektir.
            {
                string oku = sr.ReadLine();
                richTextBox1.Text += oku + "\n";
            }

            sr.Close();
        }

        private void Btnhepsi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader("C:\\Users\\Ilayda\\Desktop\\öğrenci not sistemi\\Tümöğrenciler.txt");
            while (sr.EndOfStream == false) //endofstrem=dosya sonu karakteri demektir.
            {
                string oku = sr.ReadLine();
                richTextBox1.Text += oku + "\n";
            }

            sr.Close();
        }
    }
}
