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
    public partial class FormSarjMenu : Form
    {
        public FormSarjMenu()
        {
            InitializeComponent();
        }
        public static double kalanEnerji=0;
        private void FormSarjMenu_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(pilYazdir);
            if (t1.ThreadState==ThreadState.Unstarted)
            {
                t1.Start();
            }
       
        }
        public void pilYazdir()
        {
            try
            {
                while (true)
                {
                      Thread.Sleep(100);
                        PilYüzde.Value = Convert.ToInt32(Form1.bataryaToplam);
                    label4.Text = (Form1.bataryaToplam * 12).ToString();
                    kalanEnerji = Convert.ToDouble(label4.Text);
                    
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
