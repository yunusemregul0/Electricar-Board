
namespace Electricar_Board
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMotor = new System.Windows.Forms.Button();
            this.btnBatarya = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFormlar = new System.Windows.Forms.Panel();
            this.zeroitAsanaClock1 = new Zeroit.Framework.Gauges.Clocks.ZeroitAsanaClock.ZeroitAsanaClock();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelFormlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnPort);
            this.panelMenu.Controls.Add(this.btnLog);
            this.panelMenu.Controls.Add(this.btnMotor);
            this.panelMenu.Controls.Add(this.btnBatarya);
            this.panelMenu.Controls.Add(this.btnAnasayfa);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(292, 699);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPort
            // 
            this.btnPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPort.FlatAppearance.BorderSize = 0;
            this.btnPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPort.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPort.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPort.Image = ((System.Drawing.Image)(resources.GetObject("btnPort.Image")));
            this.btnPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPort.Location = new System.Drawing.Point(0, 460);
            this.btnPort.Name = "btnPort";
            this.btnPort.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPort.Size = new System.Drawing.Size(292, 88);
            this.btnPort.TabIndex = 6;
            this.btnPort.Text = "    Port Menüsü";
            this.btnPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(0, 372);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLog.Size = new System.Drawing.Size(292, 88);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "    Log Menüsü";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnMotor
            // 
            this.btnMotor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotor.FlatAppearance.BorderSize = 0;
            this.btnMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotor.Image = ((System.Drawing.Image)(resources.GetObject("btnMotor.Image")));
            this.btnMotor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotor.Location = new System.Drawing.Point(0, 284);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMotor.Size = new System.Drawing.Size(292, 88);
            this.btnMotor.TabIndex = 4;
            this.btnMotor.Text = "    Şarj Menüsü";
            this.btnMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotor.UseVisualStyleBackColor = true;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // btnBatarya
            // 
            this.btnBatarya.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBatarya.FlatAppearance.BorderSize = 0;
            this.btnBatarya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatarya.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatarya.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBatarya.Image = ((System.Drawing.Image)(resources.GetObject("btnBatarya.Image")));
            this.btnBatarya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatarya.Location = new System.Drawing.Point(0, 196);
            this.btnBatarya.Name = "btnBatarya";
            this.btnBatarya.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBatarya.Size = new System.Drawing.Size(292, 88);
            this.btnBatarya.TabIndex = 3;
            this.btnBatarya.Text = "  Batarya Menüsü";
            this.btnBatarya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatarya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatarya.UseVisualStyleBackColor = true;
            this.btnBatarya.Click += new System.EventHandler(this.btnBatarya_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 108);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnasayfa.Size = new System.Drawing.Size(292, 88);
            this.btnAnasayfa.TabIndex = 2;
            this.btnAnasayfa.Text = "   Ana Sayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogo.Controls.Add(this.lblTarih);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(292, 108);
            this.panelLogo.TabIndex = 1;
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(31, 59);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(120, 40);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Electricar";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electricar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(292, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1116, 108);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(987, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 39);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "O";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1031, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(38, 39);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1075, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(339, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electricar Uygulamasına Hoşgeldiniz!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelFormlar
            // 
            this.panelFormlar.Controls.Add(this.zeroitAsanaClock1);
            this.panelFormlar.Controls.Add(this.pictureBox1);
            this.panelFormlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormlar.Location = new System.Drawing.Point(292, 108);
            this.panelFormlar.Name = "panelFormlar";
            this.panelFormlar.Size = new System.Drawing.Size(1116, 591);
            this.panelFormlar.TabIndex = 2;
            // 
            // zeroitAsanaClock1
            // 
            this.zeroitAsanaClock1.AllowTransparency = true;
            this.zeroitAsanaClock1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroitAsanaClock1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAsanaClock1.DigitalFont = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zeroitAsanaClock1.HourHandColor = System.Drawing.Color.Red;
            this.zeroitAsanaClock1.HourTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zeroitAsanaClock1.HourTicksColor = System.Drawing.Color.Orange;
            this.zeroitAsanaClock1.Location = new System.Drawing.Point(516, 320);
            this.zeroitAsanaClock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zeroitAsanaClock1.MinuteHandColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zeroitAsanaClock1.MinuteTicksColor = System.Drawing.Color.Black;
            this.zeroitAsanaClock1.Name = "zeroitAsanaClock1";
            this.zeroitAsanaClock1.SecondHandColor = System.Drawing.Color.SlateBlue;
            this.zeroitAsanaClock1.ShowLabelTime = true;
            this.zeroitAsanaClock1.Size = new System.Drawing.Size(215, 258);
            this.zeroitAsanaClock1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 6);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(823, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 699);
            this.Controls.Add(this.panelFormlar);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1426, 746);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelFormlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.Button btnBatarya;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFormlar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTarih;
        private Zeroit.Framework.Gauges.Clocks.ZeroitAsanaClock.ZeroitAsanaClock zeroitAsanaClock1;
        private System.Windows.Forms.Timer timer1;
    }
}

