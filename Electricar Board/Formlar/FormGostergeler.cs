using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;

namespace Electricar_Board.Formlar
{
    public partial class FormGostergeler : Form
    {
        
        public FormGostergeler()
        {
            InitializeComponent();
        }
        static int dakika = 0, saniye = 1, salise = 1, turSayi = 1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void ForrmAnasayfa_Load(object sender, EventArgs e)
        {            
           
            Thread t3 = new Thread(gostergeYazdir);
            t3.Start();
            try
            {
               // hızGösterge.Value = Convert.ToInt16(Formlar.FormPortMenu.sqlVeriler[0]);

                hızGösterge.Value = Convert.ToInt32(Formlar.FormPortMenu.array[1]);
                lblHızDegerAna.Text = Formlar.FormPortMenu.array[1].ToString();
                //solMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[1]);
                //sagMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[2]);
                //solMotorSıcaklıkAna.Value = Convert.ToInt16(FormPortMenu.array[3]);
                //sagMotorSıcaklıkAnaEkran.Value = Convert.ToInt16(FormPortMenu.array[4]);
                bataryaGerilimAna.Text =Form1.bataryaToplam.ToString(); 
                bataryaSicaklikAna.Text = FormPortMenu.array[27].ToString();
            }
            catch (Exception)
            {

            }

        }
        public static int value = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            lblDakika.Text=dakika.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
            }
            lblSaniye.Text = Convert.ToString(saniye);
            saniye++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;

            }
            lblSalise.Text = Convert.ToString(salise);
            salise++;
        }

        private void btnTurBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start(); timer2.Start(); timer3.Start();
        }

        private void btnTurBitir_Click(object sender, EventArgs e)
        {
            String turZaman = turSayi+". Tur =>"+ lblDakika.Text + ":" + lblSaniye.Text + ":" + lblSalise.Text;
            listboxTur.Items.Add(turZaman);
            turSayi++;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop();
            lblSalise.Text = "00";
            lblSaniye.Text = "00";
            lblDakika.Text = "00";
        }
        public static double bataryaToplam=0;
       
        public void gostergeYazdir()
        {
            try
            {
                while (true)
                {
                    if (Formlar.FormPortMenu.com_bool==true)
                    {
                        if (DiziParse.isaret == "+")
                        {
                            label1.Text = "D";
                            // hızGösterge.Value = Convert.ToInt16(Formlar.FormPortMenu.sqlVeriler[0]);

                            hızGösterge.Value = Convert.ToInt32(Formlar.FormPortMenu.array[1]);
                            lblHızDegerAna.Text = Formlar.FormPortMenu.array[1].ToString();
                            //solMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[1]);
                            //sagMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[2]);
                            //solMotorSıcaklıkAna.Value = Convert.ToInt16(FormPortMenu.array[3]);
                            //sagMotorSıcaklıkAnaEkran.Value = Convert.ToInt16(FormPortMenu.array[4]);
                            //for (int i = 4; i < 28; i++)
                            //{
                            //    bataryaToplam += Formlar.FormPortMenu.array[i];
                            //}
                            bataryaGerilimAna.Text = Form1.bataryaToplam.ToString();
                            bataryaSicaklikAna.Text = FormPortMenu.array[26].ToString();
                            
                        }


                        else if (DiziParse.isaret == "-")
                        {
                            label1.Text = "R";
                            hızGösterge.Value = Convert.ToInt32(Formlar.FormPortMenu.array[1]);
                            lblHızDegerAna.Text = Formlar.FormPortMenu.array[1].ToString();
                            //solMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[1]);
                            //sagMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[2]);
                            //solMotorSıcaklıkAna.Value = Convert.ToInt16(FormPortMenu.array[3]);
                            //sagMotorSıcaklıkAnaEkran.Value = Convert.ToInt16(FormPortMenu.array[4]);
                            //bataryaGerilimAna.Text = FormPortMenu.array[1].ToString(); hücreleri topla
                            bataryaGerilimAna.Text = Form1.bataryaToplam.ToString();

                            bataryaSicaklikAna.Text = FormPortMenu.array[26].ToString();
                        }
                    }
                    else if (Formlar.FormPortMenu.com_bool==false)
                    {
                        if (Formlar.FormPortMenu.docsVeriler[1]=="1")
                        {
                            label1.Text = "D";
                            // hızGösterge.Value = Convert.ToInt16(Formlar.FormPortMenu.sqlVeriler[0]);

                            hızGösterge.Value = Convert.ToInt32(Formlar.FormPortMenu.docsVeriler[2]);
                            lblHızDegerAna.Text = Formlar.FormPortMenu.docsVeriler[2].ToString();
                            //solMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[1]);
                            //sagMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[2]);
                            //solMotorSıcaklıkAna.Value = Convert.ToInt16(FormPortMenu.array[3]);
                            //sagMotorSıcaklıkAnaEkran.Value = Convert.ToInt16(FormPortMenu.array[4]);
                            //bataryaGerilimAna.Text = FormPortMenu.array[1].ToString(); hücreleri topla
                            bataryaGerilimAna.Text = Form1.bataryaToplam.ToString();

                            bataryaSicaklikAna.Text = FormPortMenu.docsVeriler[3];
                        }
                        else if (Formlar.FormPortMenu.docsVeriler[1] == "2")
                        {
                            label1.Text = "R";
                            // hızGösterge.Value = Convert.ToInt16(Formlar.FormPortMenu.sqlVeriler[0]);

                            hızGösterge.Value = Convert.ToInt32(Formlar.FormPortMenu.docsVeriler[2]);
                            lblHızDegerAna.Text = Formlar.FormPortMenu.docsVeriler[2];
                            //solMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[1]);
                            //sagMotorGerilimGosterge.Value = Convert.ToInt16(FormPortMenu.array[2]);
                            //solMotorSıcaklıkAna.Value = Convert.ToInt16(FormPortMenu.array[3]);
                            //sagMotorSıcaklıkAnaEkran.Value = Convert.ToInt16(FormPortMenu.array[4]);
                            //bataryaGerilimAna.Text = FormPortMenu.array[1].ToString(); hücreleri topla
                            bataryaGerilimAna.Text = Form1.bataryaToplam.ToString();

                            bataryaSicaklikAna.Text = FormPortMenu.docsVeriler[3];
                        }

                    }
                    
                        
                    

                }
            }
            catch (Exception)
            {
                
            }
            
            
        }

        private void listboxTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
