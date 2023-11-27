namespace _12RPL2_06_Ticketing.masterform
{
    partial class FormMasterMaskapai
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
            btnSimpan = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            txtJumlahKru = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(699, 640);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(86, 31);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(542, 640);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(542, 432);
            txtDeskripsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(243, 107);
            txtDeskripsi.TabIndex = 31;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(105, 471);
            txtPerusahaan.Margin = new Padding(3, 4, 3, 4);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(243, 27);
            txtPerusahaan.TabIndex = 27;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(105, 432);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(243, 27);
            txtNama.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 436);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 25;
            label8.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 513);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 22;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 475);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 436);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(15, 91);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 315);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.MinimumWidth = 6;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.UseColumnTextForButtonValue = true;
            BtnEdit.Width = 125;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.MinimumWidth = 6;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.UseColumnTextForButtonValue = true;
            BtnDelete.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 45);
            label2.Name = "label2";
            label2.Size = new Size(351, 20);
            label2.TabIndex = 18;
            label2.Text = "Semua Maskapai Yang Terdaftar Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 17;
            label1.Text = "Master Maskapai";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(105, 511);
            txtJumlahKru.Margin = new Padding(3, 4, 3, 4);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(243, 27);
            txtJumlahKru.TabIndex = 34;
            // 
            // FormMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 688);
            Controls.Add(txtJumlahKru);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMasterMaskapai";
            Text = "FormMasterMaskapai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private NumericUpDown txtJumlahKru;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}