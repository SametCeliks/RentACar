
namespace rent_a_carBitirmeproje
{
    partial class CarRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRecord));
            this.numberplatetxt = new System.Windows.Forms.TextBox();
            this.brandcmb = new System.Windows.Forms.ComboBox();
            this.seriecmb = new System.Windows.Forms.ComboBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.kmtxt = new System.Windows.Forms.TextBox();
            this.fuelcmb = new System.Windows.Forms.ComboBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bttnPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberplatetxt
            // 
            this.numberplatetxt.Location = new System.Drawing.Point(156, 44);
            this.numberplatetxt.Name = "numberplatetxt";
            this.numberplatetxt.Size = new System.Drawing.Size(121, 20);
            this.numberplatetxt.TabIndex = 0;
            // 
            // brandcmb
            // 
            this.brandcmb.FormattingEnabled = true;
            this.brandcmb.Items.AddRange(new object[] {
            "Renault",
            "Fiat",
            "Opel",
            "Nissan ",
            "Honda",
            "Ford"});
            this.brandcmb.Location = new System.Drawing.Point(156, 90);
            this.brandcmb.Name = "brandcmb";
            this.brandcmb.Size = new System.Drawing.Size(121, 21);
            this.brandcmb.TabIndex = 1;
            this.brandcmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // seriecmb
            // 
            this.seriecmb.FormattingEnabled = true;
            this.seriecmb.Location = new System.Drawing.Point(156, 137);
            this.seriecmb.Name = "seriecmb";
            this.seriecmb.Size = new System.Drawing.Size(121, 21);
            this.seriecmb.TabIndex = 2;
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(156, 184);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(121, 20);
            this.yeartxt.TabIndex = 3;
            // 
            // colortxt
            // 
            this.colortxt.Location = new System.Drawing.Point(156, 230);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(121, 20);
            this.colortxt.TabIndex = 4;
            // 
            // kmtxt
            // 
            this.kmtxt.Location = new System.Drawing.Point(156, 276);
            this.kmtxt.Name = "kmtxt";
            this.kmtxt.Size = new System.Drawing.Size(121, 20);
            this.kmtxt.TabIndex = 5;
            // 
            // fuelcmb
            // 
            this.fuelcmb.FormattingEnabled = true;
            this.fuelcmb.Items.AddRange(new object[] {
            "Diesel",
            "Gasoline",
            "Gasoline+Gas"});
            this.fuelcmb.Location = new System.Drawing.Point(156, 322);
            this.fuelcmb.Name = "fuelcmb";
            this.fuelcmb.Size = new System.Drawing.Size(121, 21);
            this.fuelcmb.TabIndex = 6;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(156, 369);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(121, 20);
            this.pricetxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model(YEAR)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fuel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(128, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "SAVE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "araçkayıt222.png");
            this.ımageList1.Images.SetKeyName(1, "indir.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(257, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 18;
            this.button2.Text = "CANCEL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnPicture
            // 
            this.bttnPicture.BackColor = System.Drawing.Color.White;
            this.bttnPicture.Location = new System.Drawing.Point(385, 346);
            this.bttnPicture.Name = "bttnPicture";
            this.bttnPicture.Size = new System.Drawing.Size(143, 33);
            this.bttnPicture.TabIndex = 19;
            this.bttnPicture.Text = "Add Picture";
            this.bttnPicture.UseVisualStyleBackColor = false;
            this.bttnPicture.Click += new System.EventHandler(this.bttnPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CarRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(594, 510);
            this.Controls.Add(this.bttnPicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.fuelcmb);
            this.Controls.Add(this.kmtxt);
            this.Controls.Add(this.colortxt);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.seriecmb);
            this.Controls.Add(this.brandcmb);
            this.Controls.Add(this.numberplatetxt);
            this.Name = "CarRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CarRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberplatetxt;
        private System.Windows.Forms.ComboBox brandcmb;
        private System.Windows.Forms.ComboBox seriecmb;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.TextBox kmtxt;
        private System.Windows.Forms.ComboBox fuelcmb;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttnPicture;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}