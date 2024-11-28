
namespace rent_a_carBitirmeproje
{
    partial class showcustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showcustomer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtNamesurname = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(405, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellStyleChanged);
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.White;
            this.bttnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCancel.ImageIndex = 2;
            this.bttnCancel.ImageList = this.ımageList1;
            this.bttnCancel.Location = new System.Drawing.Point(405, 306);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(101, 48);
            this.bttnCancel.TabIndex = 23;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "güncelle.png");
            this.ımageList1.Images.SetKeyName(1, "indir (1).jpeg");
            this.ımageList1.Images.SetKeyName(2, "indir.png");
            this.ımageList1.Images.SetKeyName(3, "indir (2).jpeg");
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.White;
            this.bttnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnUpdate.ImageIndex = 3;
            this.bttnUpdate.ImageList = this.ımageList1;
            this.bttnUpdate.Location = new System.Drawing.Point(134, 306);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(101, 48);
            this.bttnUpdate.TabIndex = 22;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(115, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(106, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(73, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(116, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(246, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(246, 188);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(152, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(246, 144);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(152, 20);
            this.txtPhonenumber.TabIndex = 14;
            // 
            // txtNamesurname
            // 
            this.txtNamesurname.Location = new System.Drawing.Point(246, 100);
            this.txtNamesurname.Name = "txtNamesurname";
            this.txtNamesurname.Size = new System.Drawing.Size(152, 20);
            this.txtNamesurname.TabIndex = 13;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(246, 56);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(152, 20);
            this.txtTc.TabIndex = 12;
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.Color.White;
            this.bttnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDelete.ImageIndex = 1;
            this.bttnDelete.ImageList = this.ımageList1;
            this.bttnDelete.Location = new System.Drawing.Point(275, 306);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(101, 48);
            this.bttnDelete.TabIndex = 24;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(664, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "TC No\'dan Ara :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(805, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1032, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtNamesurname);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "showcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Customer Page";
            this.Load += new System.EventHandler(this.showcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtNamesurname;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}