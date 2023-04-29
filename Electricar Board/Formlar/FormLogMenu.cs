using DevExpress.CodeParser;
using DevExpress.Spreadsheet;
using DevExpress.Utils.MVVM;
using DevExpress.XtraPrinting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Electricar_Board.Formlar
{

    public partial class FormLogMenu : Form
    {
        public static DataGridView logGrid;
        public static RichTextBox logTextBox;

        
        public static ArrayList loglist=new ArrayList();
        public FormLogMenu()
        {
            InitializeComponent();
        }
        
        private void FormLogMenu_Load(object sender, EventArgs e)
        { 
            //logTextBox= richTextBox1;
            //logGrid = dataGridView1;
            //timer1.Start();           
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
       
        public static int salise = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    salise = salise + 500;
           
        //    if (Formlar.FormPortMenu.array != null)
        //    {
        //        logGrid.Rows.Add(salise, Formlar.FormPortMenu.array[1], Formlar.FormPortMenu.array[26], "","");     
        //    }
        //    else
        //    {                  
        //        logGrid.Rows.Add(salise, Formlar.FormPortMenu.array[1], Formlar.FormPortMenu.array[26], "", "");
        //    }
           

        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaAdi = "Electricar_veriler.txt";
            string dosyaYolu = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dosyaAdi);

            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(dosyaYolu))
            {
                try
                {
                    dosya.Write("Salise, Araç Hızı, Batarya Paketi Sıcaklığı, Toplam Batarya Gerilimi, Kalan Enerji Miktarı\n");
                    for (int i = 0; i < Form1.loglar.Count; i++)
                    {
                        dosya.Write(Form1.loglar[i].ToString()); //salise
                        dosya.Write(", ");
                        dosya.Write(Form1.loglar[i + 1].ToString()); //hız
                        dosya.Write(", ");
                        dosya.Write(Form1.loglar[i + 2].ToString()); //batarya sicaklik
                        dosya.Write(", ");
                        dosya.Write(Form1.loglar[i + 3].ToString()); //Toplam batarya gerilim
                        dosya.Write(", ");
                        dosya.Write(Form1.loglar[i + 4].ToString()); //Kalan enerji miktarı
                        dosya.Write('\n');
                        
                        i = i + 4;

                    }               
                    dosya.Close();
                }
                catch (Exception)
                {

                  
                }
                string filePath = @"C:\Users\yunus\Desktop\Electricar_veriler.txt";
                string fileContent = "";

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        fileContent += line + "\n";
                    }
                }

                // Tüm dosya içeriğini richTextBox'a yazdır
                richTextBox1.Text = fileContent;



            }
            //    timer1.Stop();
            //   
            //    SaveFileDialog saveFileDialog = new SaveFileDialog();
            //    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            //    saveFileDialog.Title = "Save file as...";
            //    saveFileDialog.ShowDialog();

            //    
            //    if (saveFileDialog.FileName != "")
            //    {
            //        StreamWriter writer = null;

            //        try
            //        {
            //            writer = new StreamWriter(saveFileDialog.FileName);

            //            // DataGridView sütunlarının adları
            //            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //            {
            //                writer.Write(dataGridView1.Columns[i].HeaderText);

            //                if (i < dataGridView1.Columns.Count - 1)
            //                {
            //                    writer.Write(",");
            //                }
            //            }

            //            writer.WriteLine();

            //           
            //            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //            {
            //                for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //                {
            //                    writer.Write(dataGridView1.Rows[i].Cells[j].Value);

            //                    if (j < dataGridView1.Columns.Count - 1)
            //                    {
            //                        writer.Write(",");
            //                    }
            //                }

            //                writer.WriteLine();
            //            }

            //            MessageBox.Show("Dosya başarıyla kaydedildi.");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error: " + ex.Message);
            //        }
            //        finally
            //        {
            //            if (writer != null)
            //            {
            //                writer.Close();
            //            }
            //        }
            //    }
        }


    }
}
