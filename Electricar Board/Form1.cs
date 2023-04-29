using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using DevExpress.Data;
using System.Collections;

namespace Electricar_Board
{    

    
    public partial class Form1 : Form
    {

       
        //Degiskenler
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public static ArrayList loglar=new ArrayList();
        //Ctor
        public Form1()
        {
            
            //Thread thread = new Thread(DiziYazdir.gostergeYazdir);
            //thread.Start();

            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            random = new Random();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex==index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                }
            }
        }
        public void gunYazdir()
        {
            while (true)
            {
                lblTarih.Text = DateTime.Now.ToString();
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 0, 64);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormlar.Controls.Add(childForm);
            this.panelFormlar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FormGostergeler(), sender);
        }

        private void btnBatarya_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FormBataryaMenu(), sender);
           // OpenChildForm(new Formlar.FormBataryaMenu(), sender);
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FormSarjMenu(), sender);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FormLogMenu(), sender);
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FormPortMenu(), sender);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {         
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);     
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(gunYazdir);
            t1.Start();

            Formlar.FormPortMenu.com_bool = false;
            Formlar.FormPortMenu.docs_bool = false;

            Formlar.FormPortMenu.docs.Start();
            Formlar.FormPortMenu.t3.Start();

            timer1.Start();
       

            //Thread t1 = new Thread(gostergeYazdir);
            //t1.Start();
            //Thread t2 = new Thread(pilYazdir);
            //t2.Start();

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        public static int salise = 0;
        public static double bataryaToplam = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            salise = salise + 500;
            loglar.Add(salise);
            loglar.Add(Formlar.FormPortMenu.array[1]);
            loglar.Add(Formlar.FormPortMenu.array[26]);
            try
            {
                bataryaToplam = Formlar.FormPortMenu.array[2] + Formlar.FormPortMenu.array[3] + Formlar.FormPortMenu.array[4] + Formlar.FormPortMenu.array[5] + Formlar.FormPortMenu.array[6] + Formlar.FormPortMenu.array[7] + Formlar.FormPortMenu.array[8] + Formlar.FormPortMenu.array[9] +
                Formlar.FormPortMenu.array[10] + Formlar.FormPortMenu.array[11] + Formlar.FormPortMenu.array[12] + Formlar.FormPortMenu.array[13] + Formlar.FormPortMenu.array[14] + Formlar.FormPortMenu.array[15] +
                Formlar.FormPortMenu.array[16] + Formlar.FormPortMenu.array[17] + Formlar.FormPortMenu.array[18] + Formlar.FormPortMenu.array[19] + Formlar.FormPortMenu.array[20] + Formlar.FormPortMenu.array[21] +
                Formlar.FormPortMenu.array[22] + Formlar.FormPortMenu.array[23] + Formlar.FormPortMenu.array[24] + Formlar.FormPortMenu.array[25];
            }
            catch (Exception)
            {

            }
            loglar.Add(bataryaToplam);
            loglar.Add(Formlar.FormSarjMenu.kalanEnerji);
            
            

        }

       
        //public void gostergeYazdir()
        //{

        //    while (true)
        //    {

        //        for (int i = 0; i < 40; i++)
        //        {
        //            Thread.Sleep(1000);


        //        }
        //    }


        //}
        //public static void pilYazdir()
        //{
        //    while (true)
        //    {
        //        Formlar.FormBataryaMenu fb = new Formlar.FormBataryaMenu();
        //        for (int i = 0; i < 40; i++)
        //        {
        //            Thread.Sleep(1000);
        //            try
        //            {
        //                //Formlar.FormBataryaMenu.lblBataryaMenuH1G.Text = i.ToString();

        //            }
        //            catch (Exception)
        //            {


        //            }

        //        }
        //    }
        //}
    }
}
