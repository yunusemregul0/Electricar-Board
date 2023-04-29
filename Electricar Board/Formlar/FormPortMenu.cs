using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using DevExpress.Utils.Extensions;
using DevExpress.Data;

namespace Electricar_Board.Formlar
{
    public partial class FormPortMenu : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        public static double[] array = new double[27];
        static String data;

        public static Thread docs = new Thread(veriOku);
        public static Thread t3 = new Thread(veriAl);

        public static SerialPort _serialPort=null;

        public static string[] docsVeriler = new string[31];

        public static bool com_bool=false;
        public static bool docs_bool=false;

        public FormPortMenu()
        {
            InitializeComponent();
        }
        
        private void FormPortMenu_Load(object sender, EventArgs e)
        {
          
            foreach (var item in portlar)
                {
                    comboBox1.Items.Add(item);
                    comboBox1.SelectedIndex = 0;
                }
            button1.Visible = !com_bool;
            button2.Visible = com_bool;
            button3.Visible = !docs_bool;
            button4.Visible = docs_bool;
            
          
            comboBox2.SelectedIndex =5 ;

        }


      
        public void button1_Click(object sender, EventArgs e)
        {
            //if (_serialPort == null || _serialPort.IsOpen==false)
            //{
                _serialPort = new SerialPort();
                _serialPort.PortName = comboBox1.Text;
                _serialPort.NewLine = "1";
                _serialPort.BaudRate = Convert.ToInt32(comboBox2.Text);
                try
                {
                    _serialPort.Open();
                    label2.Text = "Bağlantı Açıldı";
                    button1.Visible = false;
                    button2.Visible = true;
                    com_bool = true;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata:" + hata.Message);
                }
            button1.Visible=false;

                
            //}        

    }
      
        public static void veriAl()
        {
            while (true)
            {
                while (com_bool)
                {
                    try
                    {
                        data = _serialPort.ReadLine();
                        DiziParse.diziParse(data, array);
                    }
                    catch (Exception ex)
                    {
                        if (ex is IOException || ex is ObjectDisposedException)
                        {
                            break;
                        }
                    }
                }
            }


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                label2.Text = "Bağlantı kapalı";
                button1.Visible = true;
                button2.Visible = false;
                com_bool = false;
                
            }
            catch (Exception)
            {

               
            }                
                
            
        }       
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (com_bool)
                {
                    com_bool = false;
                    docs_bool = true;
                    _serialPort.Close();
          
                    button4.Visible = true;
                    docs_bool = true;
                    array = null;
                }
                else
                {
                    docs_bool = true;
                    _serialPort.Close();
                   
                    button4.Visible = true;
                    docs_bool = true;

                    array = null;
                }
                button3.Visible = false;
               
            }
            catch (Exception)
            {

                
            }
            
           
        }
        
        public static void veriOku()
        {
            while (true)
            {
                try
                {
                    while (docs_bool)
                    {

                        string[] Scopes = { SheetsService.Scope.Spreadsheets };
                        var service = new SheetsService(new BaseClientService.Initializer() { HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets { ClientId = "1036152268828-raun333hrtnma4lpu4hrrfbghrthqv39.apps.googleusercontent.com", ClientSecret = "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" }, Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result, ApplicationName = "google sheet api.net quickstart", });

                        var values = service.Spreadsheets.Values.Get("10VgAlqsbOMK2Gl-8UocOU20k71v38XzRWBmPWTJenk0", $"{"Sayfa1"}!2:2").Execute().Values;
                        var row = values.FirstOrDefault();
                        if (row != null)
                        {
                            docsVeriler[0] = row[0].ToString(); //date
                            docsVeriler[1] = row[1].ToString(); //yon   
                            docsVeriler[2] = row[2].ToString(); //hiz
                            docsVeriler[3] = row[3].ToString(); //sicaklik 
                            docsVeriler[4] = row[4].ToString(); //b1v
                            docsVeriler[5] = row[5].ToString(); //b2v
                            docsVeriler[6] = row[6].ToString(); //b3v
                            docsVeriler[7] = row[7].ToString(); //b4v
                            docsVeriler[8] = row[8].ToString(); //b5v   
                            docsVeriler[9] = row[9].ToString(); //b6v
                            docsVeriler[10] = row[10].ToString(); //b7v
                            docsVeriler[11] = row[11].ToString(); //b8v
                            docsVeriler[12] = row[12].ToString(); //b9v
                            docsVeriler[13] = row[13].ToString(); //b10v
                            docsVeriler[14] = row[14].ToString(); //b11v
                            docsVeriler[15] = row[15].ToString(); //b12v  
                            docsVeriler[16] = row[16].ToString(); //b13v
                            docsVeriler[17] = row[17].ToString(); //b14v 
                            docsVeriler[18] = row[18].ToString(); //b15v
                            docsVeriler[19] = row[19].ToString(); //b16v
                            docsVeriler[20] = row[20].ToString(); //b17v
                            docsVeriler[21] = row[21].ToString(); //b18v
                            docsVeriler[22] = row[22].ToString(); //b19v  
                            docsVeriler[23] = row[23].ToString(); //b20v
                            docsVeriler[24] = row[24].ToString(); //b21v
                            docsVeriler[25] = row[25].ToString(); //b22v
                            docsVeriler[26] = row[26].ToString(); //b23v
                            docsVeriler[27] = row[27].ToString(); //b24v
                            docsVeriler[28] = row[28].ToString(); //toplam gerilim
                            docsVeriler[29] = row[29].ToString(); //pil veri1
                            docsVeriler[30] = row[30].ToString(); //pil veri2
                            docsVeriler[31] = row[31].ToString(); //pil veri3


                        }

                    }
                }
                catch (Exception)
                {


                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                docs_bool = false;
               
                button3.Visible = true;
                button4.Visible = false;
            }
            catch (Exception)
            {

            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
      
    }
}
