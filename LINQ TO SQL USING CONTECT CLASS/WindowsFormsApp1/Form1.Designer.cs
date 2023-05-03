namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet2 = new WindowsFormsApp1.BankDataSet2();
            this.bankDataSet = new WindowsFormsApp1.BankDataSet();
            this.accountInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoTableAdapter = new WindowsFormsApp1.BankDataSetTableAdapters.AccountInfoTableAdapter();
            this.bankDataSet1 = new WindowsFormsApp1.BankDataSet1();
            this.accountInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoTableAdapter1 = new WindowsFormsApp1.BankDataSet1TableAdapters.AccountInfoTableAdapter();
            this.accountInfoTableAdapter2 = new WindowsFormsApp1.BankDataSet2TableAdapters.AccountInfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Fetch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Acnumber = new System.Windows.Forms.TextBox();
            this.bankDataSet3 = new WindowsFormsApp1.BankDataSet3();
            this.accountInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoTableAdapter3 = new WindowsFormsApp1.BankDataSet3TableAdapters.AccountInfoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bankDataSet4 = new WindowsFormsApp1.BankDataSet4();
            this.accountInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoTableAdapter4 = new WindowsFormsApp1.BankDataSet4TableAdapters.AccountInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // accountInfoBindingSource2
            // 
            this.accountInfoBindingSource2.DataMember = "AccountInfo";
            this.accountInfoBindingSource2.DataSource = this.bankDataSet2;
            // 
            // bankDataSet2
            // 
            this.bankDataSet2.DataSetName = "BankDataSet2";
            this.bankDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountInfoBindingSource
            // 
            this.accountInfoBindingSource.DataMember = "AccountInfo";
            this.accountInfoBindingSource.DataSource = this.bankDataSet;
            // 
            // accountInfoTableAdapter
            // 
            this.accountInfoTableAdapter.ClearBeforeFill = true;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountInfoBindingSource1
            // 
            this.accountInfoBindingSource1.DataMember = "AccountInfo";
            this.accountInfoBindingSource1.DataSource = this.bankDataSet1;
            // 
            // accountInfoTableAdapter1
            // 
            this.accountInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // accountInfoTableAdapter2
            // 
            this.accountInfoTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the account number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Phone number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Account balance :";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(220, 270);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(168, 22);
            this.balance.TabIndex = 7;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(220, 185);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(168, 22);
            this.phoneno.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(220, 145);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(168, 22);
            this.name.TabIndex = 10;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(53, 341);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 11;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Fetch
            // 
            this.Fetch.Location = new System.Drawing.Point(191, 341);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 12;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = true;
            this.Fetch.Click += new System.EventHandler(this.Fetch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Account number";
            // 
            // Acnumber
            // 
            this.Acnumber.Location = new System.Drawing.Point(220, 106);
            this.Acnumber.Name = "Acnumber";
            this.Acnumber.Size = new System.Drawing.Size(168, 22);
            this.Acnumber.TabIndex = 16;
            // 
            // bankDataSet3
            // 
            this.bankDataSet3.DataSetName = "BankDataSet3";
            this.bankDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountInfoBindingSource3
            // 
            this.accountInfoBindingSource3.DataMember = "AccountInfo";
            this.accountInfoBindingSource3.DataSource = this.bankDataSet3;
            // 
            // accountInfoTableAdapter3
            // 
            this.accountInfoTableAdapter3.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.accountInfoBindingSource4;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // bankDataSet4
            // 
            this.bankDataSet4.DataSetName = "BankDataSet4";
            this.bankDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountInfoBindingSource4
            // 
            this.accountInfoBindingSource4.DataMember = "AccountInfo";
            this.accountInfoBindingSource4.DataSource = this.bankDataSet4;
            // 
            // accountInfoTableAdapter4
            // 
            this.accountInfoTableAdapter4.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Acnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Fetch);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.name);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource accountInfoBindingSource;
        private BankDataSetTableAdapters.AccountInfoTableAdapter accountInfoTableAdapter;
        private BankDataSet1 bankDataSet1;
        private System.Windows.Forms.BindingSource accountInfoBindingSource1;
        private BankDataSet1TableAdapters.AccountInfoTableAdapter accountInfoTableAdapter1;
        private BankDataSet2 bankDataSet2;
        private System.Windows.Forms.BindingSource accountInfoBindingSource2;
        private BankDataSet2TableAdapters.AccountInfoTableAdapter accountInfoTableAdapter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Fetch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Acnumber;
        private BankDataSet3 bankDataSet3;
        private System.Windows.Forms.BindingSource accountInfoBindingSource3;
        private BankDataSet3TableAdapters.AccountInfoTableAdapter accountInfoTableAdapter3;
        private System.Windows.Forms.ComboBox comboBox1;
        private BankDataSet4 bankDataSet4;
        private System.Windows.Forms.BindingSource accountInfoBindingSource4;
        private BankDataSet4TableAdapters.AccountInfoTableAdapter accountInfoTableAdapter4;
    }
}

