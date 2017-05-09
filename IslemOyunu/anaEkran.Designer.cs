namespace IslemOyunu
{
    partial class anaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkran));
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.SesKis = new System.Windows.Forms.PictureBox();
            this.oynaBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayanYazi = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yuksekSkorBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesKis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oynaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuksekSkorBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::IslemOyunu.Properties.Resources.cikis1;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(778, 459);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(172, 118);
            this.cikisBtn.TabIndex = 0;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            this.cikisBtn.MouseEnter += new System.EventHandler(this.cikisBtn_MouseEnter);
            this.cikisBtn.MouseLeave += new System.EventHandler(this.cikisBtn_MouseLeave);
            // 
            // SesKis
            // 
            this.SesKis.BackColor = System.Drawing.Color.Transparent;
            this.SesKis.BackgroundImage = global::IslemOyunu.Properties.Resources.sound;
            this.SesKis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SesKis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SesKis.Location = new System.Drawing.Point(12, 505);
            this.SesKis.Name = "SesKis";
            this.SesKis.Size = new System.Drawing.Size(53, 59);
            this.SesKis.TabIndex = 1;
            this.SesKis.TabStop = false;
            this.SesKis.Click += new System.EventHandler(this.SesKis_Click);
            // 
            // oynaBtn
            // 
            this.oynaBtn.BackColor = System.Drawing.Color.Transparent;
            this.oynaBtn.BackgroundImage = global::IslemOyunu.Properties.Resources.oyna1;
            this.oynaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oynaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oynaBtn.Location = new System.Drawing.Point(283, 331);
            this.oynaBtn.Name = "oynaBtn";
            this.oynaBtn.Size = new System.Drawing.Size(360, 121);
            this.oynaBtn.TabIndex = 2;
            this.oynaBtn.TabStop = false;
            this.oynaBtn.Click += new System.EventHandler(this.oynaBtn_Click);
            this.oynaBtn.MouseEnter += new System.EventHandler(this.oynaBtn_MouseEnter);
            this.oynaBtn.MouseLeave += new System.EventHandler(this.oynaBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semanur KARTAL | Halil Çağrı AKKUZU";
            // 
            // kayanYazi
            // 
            this.kayanYazi.Interval = 25;
            this.kayanYazi.Tick += new System.EventHandler(this.kayanYazi_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::IslemOyunu.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(93, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 118);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(240, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 108);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // yuksekSkorBtn
            // 
            this.yuksekSkorBtn.BackColor = System.Drawing.Color.Transparent;
            this.yuksekSkorBtn.BackgroundImage = global::IslemOyunu.Properties.Resources.skor1;
            this.yuksekSkorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yuksekSkorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yuksekSkorBtn.Location = new System.Drawing.Point(298, 468);
            this.yuksekSkorBtn.Name = "yuksekSkorBtn";
            this.yuksekSkorBtn.Size = new System.Drawing.Size(334, 68);
            this.yuksekSkorBtn.TabIndex = 6;
            this.yuksekSkorBtn.TabStop = false;
            this.yuksekSkorBtn.Click += new System.EventHandler(this.yuksekSkorBtn_Click);
            this.yuksekSkorBtn.MouseEnter += new System.EventHandler(this.yuksekSkorBtn_MouseEnter);
            this.yuksekSkorBtn.MouseLeave += new System.EventHandler(this.yuksekSkorBtn_MouseLeave);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IslemOyunu.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.ControlBox = false;
            this.Controls.Add(this.yuksekSkorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oynaBtn);
            this.Controls.Add(this.SesKis);
            this.Controls.Add(this.cikisBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Oyunu";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesKis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oynaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuksekSkorBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.PictureBox SesKis;
        private System.Windows.Forms.PictureBox oynaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer kayanYazi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox yuksekSkorBtn;
    }
}

