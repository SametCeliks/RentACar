
namespace rent_a_carBitirmeproje
{
    partial class ShowCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCars));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.bttnPicture = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.fuelcmb = new System.Windows.Forms.ComboBox();
            this.kmtxt = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.seriecmb = new System.Windows.Forms.ComboBox();
            this.brandcmb = new System.Windows.Forms.ComboBox();
            this.numberplatetxt = new System.Windows.Forms.TextBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 466);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbCars
            // 
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Items.AddRange(new object[] {
            "All Cars",
            "Empty Cars",
            "Full Cars"});
            this.cmbCars.Location = new System.Drawing.Point(1222, 75);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(202, 21);
            this.cmbCars.TabIndex = 1;
            this.cmbCars.SelectedIndexChanged += new System.EventHandler(this.cmbCars_SelectedIndexChanged);
            // 
            // bttnPicture
            // 
            this.bttnPicture.BackColor = System.Drawing.Color.White;
            this.bttnPicture.Location = new System.Drawing.Point(651, 747);
            this.bttnPicture.Name = "bttnPicture";
            this.bttnPicture.Size = new System.Drawing.Size(125, 33);
            this.bttnPicture.TabIndex = 39;
            this.bttnPicture.Text = "Change Picture";
            this.bttnPicture.UseVisualStyleBackColor = false;
            this.bttnPicture.Click += new System.EventHandler(this.bttnPicture_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.White;
            this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCancel.ImageIndex = 1;
            this.bttnCancel.ImageList = this.ımageList1;
            this.bttnCancel.Location = new System.Drawing.Point(220, 506);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(123, 51);
            this.bttnCancel.TabIndex = 38;
            this.bttnCancel.Text = "CANCEL";
            this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (2).jpeg");
            this.ımageList1.Images.SetKeyName(1, "indir.png");
            this.ımageList1.Images.SetKeyName(2, "indir (1).jpeg");
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.White;
            this.bttnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnUpdate.ImageIndex = 0;
            this.bttnUpdate.ImageList = this.ımageList1;
            this.bttnUpdate.Location = new System.Drawing.Point(91, 506);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(123, 51);
            this.bttnUpdate.TabIndex = 37;
            this.bttnUpdate.Text = "UPDATE";
            this.bttnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Model(YEAR)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Number Plate";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(119, 463);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(121, 20);
            this.pricetxt.TabIndex = 27;
            // 
            // fuelcmb
            // 
            this.fuelcmb.FormattingEnabled = true;
            this.fuelcmb.Items.AddRange(new object[] {
            "Diesel",
            "Gasoline",
            "Gasoline+Gas"});
            this.fuelcmb.Location = new System.Drawing.Point(119, 416);
            this.fuelcmb.Name = "fuelcmb";
            this.fuelcmb.Size = new System.Drawing.Size(121, 21);
            this.fuelcmb.TabIndex = 26;
            // 
            // kmtxt
            // 
            this.kmtxt.Location = new System.Drawing.Point(119, 370);
            this.kmtxt.Name = "kmtxt";
            this.kmtxt.Size = new System.Drawing.Size(121, 20);
            this.kmtxt.TabIndex = 25;
            // 
            // colortxt
            // 
            this.colortxt.Location = new System.Drawing.Point(119, 324);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(121, 20);
            this.colortxt.TabIndex = 24;
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(119, 278);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(121, 20);
            this.yeartxt.TabIndex = 23;
            // 
            // seriecmb
            // 
            this.seriecmb.FormattingEnabled = true;
            this.seriecmb.Location = new System.Drawing.Point(119, 231);
            this.seriecmb.Name = "seriecmb";
            this.seriecmb.Size = new System.Drawing.Size(121, 21);
            this.seriecmb.TabIndex = 22;
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
            this.brandcmb.Location = new System.Drawing.Point(119, 184);
            this.brandcmb.Name = "brandcmb";
            this.brandcmb.Size = new System.Drawing.Size(121, 21);
            this.brandcmb.TabIndex = 21;
            this.brandcmb.SelectedIndexChanged += new System.EventHandler(this.brandcmb_SelectedIndexChanged);
            // 
            // numberplatetxt
            // 
            this.numberplatetxt.Location = new System.Drawing.Point(119, 138);
            this.numberplatetxt.Name = "numberplatetxt";
            this.numberplatetxt.Size = new System.Drawing.Size(121, 20);
            this.numberplatetxt.TabIndex = 20;
            this.numberplatetxt.TextChanged += new System.EventHandler(this.numberplatetxt_TextChanged);
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.Color.White;
            this.bttnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDelete.ImageIndex = 2;
            this.bttnDelete.ImageList = this.ımageList1;
            this.bttnDelete.Location = new System.Drawing.Point(1301, 633);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(123, 51);
            this.bttnDelete.TabIndex = 40;
            this.bttnDelete.Text = "DELETE";
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(793, 633);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(353, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ShowCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1457, 864);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnPicture);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnUpdate);
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
            this.Controls.Add(this.cmbCars);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowCars";
            this.Load += new System.EventHandler(this.ShowCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Button bttnPicture;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.ComboBox fuelcmb;
        private System.Windows.Forms.TextBox kmtxt;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.ComboBox seriecmb;
        private System.Windows.Forms.ComboBox brandcmb;
        private System.Windows.Forms.TextBox numberplatetxt;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}