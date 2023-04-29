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

namespace Electricar_Board.Formlar
{
    public partial class FormBataryaMenu : Form
    {
        public FormBataryaMenu()
        {
            InitializeComponent();
        }
        static Thread t1;
        public static int deger;
        private void Formsavas_Load(object sender, EventArgs e)
        {
            t1 = new Thread(bataryaYazdir);
            t1.Start();
            baslangicDeger();

            // lblBataryaMenuH1G.Text = deger.ToString();

        }
        public void baslangicDeger()
        {
            try
            {
                lblBataryaMenuH1G.Text = FormPortMenu.array[2].ToString();
                lblBataryaMenu1Hs.Text = FormPortMenu.array[26].ToString();

                lblBataryaMenuH2G.Text = FormPortMenu.array[3].ToString();
                lblBataryaMenuH2S.Text = FormPortMenu.array[26].ToString();
                
                lblBataryaMenuH3G.Text = FormPortMenu.array[4].ToString(); 
                lblBataryaMenuH3S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH4G.Text = FormPortMenu.array[5].ToString(); 
                lblBataryaMenuH4S.Text = FormPortMenu.array[26].ToString(); 
 
                lblBataryaMenuH5G.Text = FormPortMenu.array[6].ToString(); 
                lblBataryaMenuH5S.Text = FormPortMenu.array[26].ToString();              

                lblBataryaMenuH6G.Text = FormPortMenu.array[7].ToString(); 
                lblBataryaMenuH6S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH7G.Text = FormPortMenu.array[8].ToString(); 
                lblBataryaMenuH7S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH8G.Text = FormPortMenu.array[9].ToString(); 
                lblBataryaMenuH8S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH9G.Text = FormPortMenu.array[10].ToString(); 
                lblBataryaMenuH9S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH10G.Text = FormPortMenu.array[11].ToString(); 
                lblBataryaMenuH10S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH11G.Text = FormPortMenu.array[12].ToString(); 
                lblBataryaMenuH11S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH12G.Text = FormPortMenu.array[13].ToString(); 
                lblBataryaMenuH12S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH13G.Text = FormPortMenu.array[14].ToString(); 
                lblBataryaMenuH13S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH14G.Text = FormPortMenu.array[15].ToString(); 
                lblBataryaMenuH14S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH15G.Text = FormPortMenu.array[16].ToString(); 
                lblBataryaMenuH15S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH16G.Text = FormPortMenu.array[17].ToString(); 
                lblBataryaMenuH16S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH17G.Text = FormPortMenu.array[18].ToString(); 
                lblBataryaMenuH17S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH18G.Text = FormPortMenu.array[19].ToString(); 
                lblBataryaMenuH18S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH19G.Text = FormPortMenu.array[20].ToString(); 
                lblBataryaMenuH19S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH20G.Text = FormPortMenu.array[21].ToString(); 
                lblBataryaMenuH20S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH21G.Text = FormPortMenu.array[22].ToString(); 
                lblBataryaMenuH21S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH22G.Text = FormPortMenu.array[23].ToString(); 
                lblBataryaMenuH22S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH23G.Text = FormPortMenu.array[24].ToString(); 
                lblBataryaMenuH23S.Text = FormPortMenu.array[26].ToString(); 

                lblBataryaMenuH24G.Text = FormPortMenu.array[25].ToString(); 
                lblBataryaMenuH24S.Text = FormPortMenu.array[26].ToString(); 
            }
            catch (Exception) { 
            
            }
            
        }
        
        public void bataryaYazdir()
        {
            try
            {
                while (true)
                {
                    if (Formlar.FormPortMenu.com_bool==true)
                    {
                        lblBataryaMenuH1G.Text = FormPortMenu.array[2].ToString();
                        lblBataryaMenu1Hs.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH2G.Text = FormPortMenu.array[3].ToString();
                        lblBataryaMenuH2S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH3G.Text = FormPortMenu.array[4].ToString();
                        lblBataryaMenuH3S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH4G.Text = FormPortMenu.array[5].ToString();
                        lblBataryaMenuH4S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH5S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH5G.Text = FormPortMenu.array[6].ToString();
                        lblBataryaMenuH6G.Text = FormPortMenu.array[7].ToString();
                        lblBataryaMenuH6S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH7G.Text = FormPortMenu.array[8].ToString();
                        lblBataryaMenuH7S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH8G.Text = FormPortMenu.array[9].ToString();
                        lblBataryaMenuH8S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH9G.Text = FormPortMenu.array[10].ToString();
                        lblBataryaMenuH9S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH10G.Text = FormPortMenu.array[11].ToString();
                        lblBataryaMenuH10S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH11G.Text = FormPortMenu.array[12].ToString();
                        lblBataryaMenuH11S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH12G.Text = FormPortMenu.array[13].ToString();
                        lblBataryaMenuH12S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH13G.Text = FormPortMenu.array[14].ToString();
                        lblBataryaMenuH13S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH14G.Text = FormPortMenu.array[15].ToString();
                        lblBataryaMenuH14S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH15G.Text = FormPortMenu.array[16].ToString();
                        lblBataryaMenuH15S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH16G.Text = FormPortMenu.array[17].ToString();
                        lblBataryaMenuH16S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH17G.Text = FormPortMenu.array[18].ToString();
                        lblBataryaMenuH17S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH18G.Text = FormPortMenu.array[19].ToString();
                        lblBataryaMenuH18S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH19G.Text = FormPortMenu.array[20].ToString();
                        lblBataryaMenuH19S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH20G.Text = FormPortMenu.array[21].ToString();
                        lblBataryaMenuH20S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH21G.Text = FormPortMenu.array[22].ToString();
                        lblBataryaMenuH21S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH22G.Text = FormPortMenu.array[23].ToString();
                        lblBataryaMenuH22S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH23G.Text = FormPortMenu.array[24].ToString();
                        lblBataryaMenuH23S.Text = FormPortMenu.array[26].ToString();
                        lblBataryaMenuH24G.Text = FormPortMenu.array[25].ToString();
                        lblBataryaMenuH24S.Text = FormPortMenu.array[26].ToString();
                    }
                    else if (Formlar.FormPortMenu.com_bool==false)
                    {
                        lblBataryaMenuH1G.Text = FormPortMenu.docsVeriler[4];
                        lblBataryaMenu1Hs.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH2G.Text = FormPortMenu.docsVeriler[5];
                        lblBataryaMenuH2S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH3G.Text = FormPortMenu.docsVeriler[6];
                        lblBataryaMenuH3S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH4G.Text = FormPortMenu.docsVeriler[7];
                        lblBataryaMenuH4S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH5S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH5G.Text = FormPortMenu.docsVeriler[8];
                        lblBataryaMenuH6G.Text = FormPortMenu.docsVeriler[9];
                        lblBataryaMenuH6S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH7G.Text = FormPortMenu.docsVeriler[10];
                        lblBataryaMenuH7S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH8G.Text = FormPortMenu.docsVeriler[11];
                        lblBataryaMenuH8S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH9G.Text = FormPortMenu.docsVeriler[12];
                        lblBataryaMenuH9S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH10G.Text = FormPortMenu.docsVeriler[13];
                        lblBataryaMenuH10S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH11G.Text = FormPortMenu.docsVeriler[14];
                        lblBataryaMenuH11S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH12G.Text = FormPortMenu.docsVeriler[15];
                        lblBataryaMenuH12S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH13G.Text = FormPortMenu.docsVeriler[16];
                        lblBataryaMenuH13S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH14G.Text = FormPortMenu.docsVeriler[17];
                        lblBataryaMenuH14S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH15G.Text = FormPortMenu.docsVeriler[18];
                        lblBataryaMenuH15S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH16G.Text = FormPortMenu.docsVeriler[19];
                        lblBataryaMenuH16S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH17G.Text = FormPortMenu.docsVeriler[20];
                        lblBataryaMenuH17S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH18G.Text = FormPortMenu.docsVeriler[21];
                        lblBataryaMenuH18S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH19G.Text = FormPortMenu.docsVeriler[22];
                        lblBataryaMenuH19S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH20G.Text = FormPortMenu.docsVeriler[23];
                        lblBataryaMenuH20S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH21G.Text = FormPortMenu.docsVeriler[24];
                        lblBataryaMenuH21S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH22G.Text = FormPortMenu.docsVeriler[25];
                        lblBataryaMenuH22S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH23G.Text = FormPortMenu.docsVeriler[26];
                        lblBataryaMenuH23S.Text = FormPortMenu.docsVeriler[3];
                        lblBataryaMenuH24G.Text = FormPortMenu.docsVeriler[27];
                        lblBataryaMenuH24S.Text = FormPortMenu.docsVeriler[3];;
                    }
                    


                }

            }
            catch (Exception )
            {

            }
        }

        private void Formsavas_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
