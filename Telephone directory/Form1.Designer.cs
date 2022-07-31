namespace Telephone_directory
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLKISILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rehberDataSet = new Telephone_directory.RehberDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNTEMIZLE = new System.Windows.Forms.Button();
            this.BTNGUNCELLE = new System.Windows.Forms.Button();
            this.BTNSIL = new System.Windows.Forms.Button();
            this.TXTMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TELEFON = new System.Windows.Forms.Label();
            this.TXTSOYAD = new System.Windows.Forms.TextBox();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.MSKTEL = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBLKISILERTableAdapter = new Telephone_directory.RehberDataSetTableAdapters.TBLKISILERTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKISILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 310);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.tELEFONDataGridViewTextBoxColumn,
            this.mAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKISILERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 285);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // tELEFONDataGridViewTextBoxColumn
            // 
            this.tELEFONDataGridViewTextBoxColumn.DataPropertyName = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.Name = "tELEFONDataGridViewTextBoxColumn";
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            this.mAILDataGridViewTextBoxColumn.HeaderText = "MAIL";
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            // 
            // tBLKISILERBindingSource
            // 
            this.tBLKISILERBindingSource.DataMember = "TBLKISILER";
            this.tBLKISILERBindingSource.DataSource = this.rehberDataSet;
            // 
            // rehberDataSet
            // 
            this.rehberDataSet.DataSetName = "RehberDataSet";
            this.rehberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNTEMIZLE);
            this.groupBox2.Controls.Add(this.BTNGUNCELLE);
            this.groupBox2.Controls.Add(this.BTNSIL);
            this.groupBox2.Controls.Add(this.TXTMAIL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TELEFON);
            this.groupBox2.Controls.Add(this.TXTSOYAD);
            this.groupBox2.Controls.Add(this.TXTAD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BTNEKLE);
            this.groupBox2.Controls.Add(this.TXTID);
            this.groupBox2.Controls.Add(this.MSKTEL);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(514, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 310);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YENİ KİŞİ";
            // 
            // BTNTEMIZLE
            // 
            this.BTNTEMIZLE.Location = new System.Drawing.Point(102, 260);
            this.BTNTEMIZLE.Name = "BTNTEMIZLE";
            this.BTNTEMIZLE.Size = new System.Drawing.Size(122, 29);
            this.BTNTEMIZLE.TabIndex = 8;
            this.BTNTEMIZLE.Text = "TEMİZLE";
            this.BTNTEMIZLE.UseVisualStyleBackColor = true;
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Location = new System.Drawing.Point(102, 225);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(122, 29);
            this.BTNGUNCELLE.TabIndex = 7;
            this.BTNGUNCELLE.Text = "GÜNCELLE";
            this.BTNGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // BTNSIL
            // 
            this.BTNSIL.Location = new System.Drawing.Point(169, 190);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(66, 29);
            this.BTNSIL.TabIndex = 6;
            this.BTNSIL.Text = "SİL";
            this.BTNSIL.UseVisualStyleBackColor = true;
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // TXTMAIL
            // 
            this.TXTMAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTMAIL.Location = new System.Drawing.Point(102, 150);
            this.TXTMAIL.Name = "TXTMAIL";
            this.TXTMAIL.Size = new System.Drawing.Size(122, 26);
            this.TXTMAIL.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "MAİL:";
            // 
            // TELEFON
            // 
            this.TELEFON.AutoSize = true;
            this.TELEFON.Location = new System.Drawing.Point(46, 126);
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.Size = new System.Drawing.Size(44, 18);
            this.TELEFON.TabIndex = 8;
            this.TELEFON.Text = "TEL:";
            // 
            // TXTSOYAD
            // 
            this.TXTSOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTSOYAD.Location = new System.Drawing.Point(102, 86);
            this.TXTSOYAD.Name = "TXTSOYAD";
            this.TXTSOYAD.Size = new System.Drawing.Size(122, 26);
            this.TXTSOYAD.TabIndex = 2;
            // 
            // TXTAD
            // 
            this.TXTAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTAD.Location = new System.Drawing.Point(102, 54);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(122, 26);
            this.TXTAD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(88, 190);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(66, 29);
            this.BTNEKLE.TabIndex = 5;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(102, 22);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(122, 26);
            this.TXTID.TabIndex = 20;
            // 
            // MSKTEL
            // 
            this.MSKTEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MSKTEL.Location = new System.Drawing.Point(102, 118);
            this.MSKTEL.Mask = "(999) 000-0000";
            this.MSKTEL.Name = "MSKTEL";
            this.MSKTEL.Size = new System.Drawing.Size(122, 26);
            this.MSKTEL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tBLKISILERTableAdapter
            // 
            this.tBLKISILERTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(825, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKISILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TELEFON;
        private System.Windows.Forms.TextBox TXTSOYAD;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.MaskedTextBox MSKTEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGUNCELLE;
        private System.Windows.Forms.Button BTNSIL;
        private System.Windows.Forms.Button BTNTEMIZLE;
        private RehberDataSet rehberDataSet;
        private System.Windows.Forms.BindingSource tBLKISILERBindingSource;
        private RehberDataSetTableAdapters.TBLKISILERTableAdapter tBLKISILERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
    }
}

