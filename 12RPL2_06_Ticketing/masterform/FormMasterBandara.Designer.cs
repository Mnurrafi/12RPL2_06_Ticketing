namespace _12RPL2_06_Ticketing.masterform
{
    partial class FormMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNama = new TextBox();
            txtkodeIATA = new TextBox();
            txtKota = new TextBox();
            txtNegara = new ComboBox();
            txtJumlahTerminal = new NumericUpDown();
            txtAlamat = new TextBox();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(343, 20);
            label2.TabIndex = 1;
            label2.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, btnDelete });
            dataGridView1.Location = new Point(14, 100);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 308);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 445);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 484);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 523);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 563);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 445);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 7;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 484);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Alamat";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(105, 441);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(243, 27);
            txtNama.TabIndex = 9;
            // 
            // txtkodeIATA
            // 
            txtkodeIATA.Location = new Point(105, 480);
            txtkodeIATA.Margin = new Padding(3, 4, 3, 4);
            txtkodeIATA.Name = "txtkodeIATA";
            txtkodeIATA.Size = new Size(243, 27);
            txtkodeIATA.TabIndex = 10;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(105, 519);
            txtKota.Margin = new Padding(3, 4, 3, 4);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(243, 27);
            txtKota.TabIndex = 11;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(105, 563);
            txtNegara.Margin = new Padding(3, 4, 3, 4);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(243, 28);
            txtNegara.TabIndex = 12;
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(557, 443);
            txtJumlahTerminal.Margin = new Padding(3, 4, 3, 4);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(243, 27);
            txtJumlahTerminal.TabIndex = 13;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(557, 496);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(243, 96);
            txtAlamat.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(557, 649);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(714, 649);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.MinimumWidth = 6;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            BtnEdit.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 125;
            // 
            // FormMasterBandara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 717);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAlamat);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtkodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMasterBandara";
            Text = "FormMasterBandara";
            Load += FormMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNama;
        private TextBox txtkodeIATA;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private NumericUpDown txtJumlahTerminal;
        private TextBox txtAlamat;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}