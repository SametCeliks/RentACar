
namespace rent_a_carBitirmeproje
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.Button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 148);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.ImageKey = "exit.jpeg";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(693, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 74);
            this.button7.TabIndex = 7;
            this.button7.Text = "Exit";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.jpeg");
            this.ımageList1.Images.SetKeyName(1, "kullanıcılistele.jpeg");
            this.ımageList1.Images.SetKeyName(2, "araçkayıt.png");
            this.ımageList1.Images.SetKeyName(3, "araçlisteleme.jpeg");
            this.ımageList1.Images.SetKeyName(4, "agreement.jpeg");
            this.ımageList1.Images.SetKeyName(5, "satış.jpeg");
            this.ımageList1.Images.SetKeyName(6, "exit.jpeg");
            this.ımageList1.Images.SetKeyName(7, "satış2.jpeg");
            this.ımageList1.Images.SetKeyName(8, "araçlistele2.png");
            this.ımageList1.Images.SetKeyName(9, "araçkayıt222.png");
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.White;
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button6.ImageIndex = 7;
            this.Button6.ImageList = this.ımageList1;
            this.Button6.Location = new System.Drawing.Point(583, 45);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(104, 74);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "Sales";
            this.Button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.ImageIndex = 4;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(473, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 74);
            this.button5.TabIndex = 5;
            this.button5.Text = "Agreement";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.ImageIndex = 8;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(363, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 74);
            this.button4.TabIndex = 4;
            this.button4.Text = "Show Cars";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.ImageIndex = 9;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(253, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "Car Record";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(143, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Customer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(33, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Customer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::rent_a_carBitirmeproje.Properties.Resources.cooltext406396850585054;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(823, 638);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

