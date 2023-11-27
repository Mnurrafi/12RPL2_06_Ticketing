namespace _12RPL2_06_Ticketing.masterform
{
    partial class FormMasterKodePromo
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
            txtPresentaseDiskon = new NumericUpDown();
            btnSimpan = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            txtKodePromo = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            txtMaksimumDiskon = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(154, 545);
            txtPresentaseDiskon.Margin = new Padding(3, 4, 3, 4);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(243, 27);
            txtPresentaseDiskon.TabIndex = 47;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(699, 672);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(86, 31);
            btnSimpan.TabIndex = 46;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(542, 672);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 45;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(542, 464);
            txtDeskripsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(243, 107);
            txtDeskripsi.TabIndex = 44;
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(154, 464);
            txtKodePromo.Margin = new Padding(3, 4, 3, 4);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(243, 27);
            txtKodePromo.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 468);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 41;
            label8.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 557);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 40;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 517);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 39;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 475);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 38;
            label3.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 123);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 315);
            dataGridView1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(371, 20);
            label2.TabIndex = 36;
            label2.Text = "Semua Kode Promo Yang Terdaftar Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 35;
            label1.Text = "Master Kode Promo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 595);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 48;
            label6.Text = "Maksimum Diskon";
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(154, 507);
            txtBerlakuSampai.Margin = new Padding(3, 4, 3, 4);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(243, 27);
            txtBerlakuSampai.TabIndex = 49;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(154, 584);
            txtMaksimumDiskon.Margin = new Padding(3, 4, 3, 4);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(243, 27);
            txtMaksimumDiskon.TabIndex = 50;
            // 
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 753);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(label6);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtKodePromo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown txtPresentaseDiskon;
        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private TextBox txtKodePromo;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label6;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtMaksimumDiskon;
    }
}