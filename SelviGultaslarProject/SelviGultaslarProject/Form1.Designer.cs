namespace SelviGultaslarProject
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
            this.accountTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scoreResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.scoreCalculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxExpense = new System.Windows.Forms.TextBox();
            this.txtbxWorkYear = new System.Windows.Forms.TextBox();
            this.txtbxIncome = new System.Windows.Forms.TextBox();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnKurumsal = new System.Windows.Forms.RadioButton();
            this.rdbtnBireysel = new System.Windows.Forms.RadioButton();
            this.chckbxIsImarli = new System.Windows.Forms.CheckBox();
            this.chckbxIsNew = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InstallmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxhouseAge = new System.Windows.Forms.TextBox();
            this.creditCalculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.txtbxMaturity = new System.Windows.Forms.TextBox();
            this.txtbxCreditScore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.accountTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountTab
            // 
            this.accountTab.Controls.Add(this.tabPage1);
            this.accountTab.Controls.Add(this.tabPage2);
            this.accountTab.Location = new System.Drawing.Point(12, 12);
            this.accountTab.Name = "accountTab";
            this.accountTab.SelectedIndex = 0;
            this.accountTab.Size = new System.Drawing.Size(626, 464);
            this.accountTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scoreResultLabel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.scoreCalculateButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbxExpense);
            this.tabPage1.Controls.Add(this.txtbxWorkYear);
            this.tabPage1.Controls.Add(this.txtbxIncome);
            this.tabPage1.Controls.Add(this.txtbxAge);
            this.tabPage1.Controls.Add(this.txtbxSurname);
            this.tabPage1.Controls.Add(this.txtbxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skor Sorgulama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scoreResultLabel
            // 
            this.scoreResultLabel.AutoSize = true;
            this.scoreResultLabel.Location = new System.Drawing.Point(302, 102);
            this.scoreResultLabel.Name = "scoreResultLabel";
            this.scoreResultLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreResultLabel.TabIndex = 15;
            this.scoreResultLabel.Text = "label18";
            this.scoreResultLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sonuç";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(302, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 30);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // scoreCalculateButton
            // 
            this.scoreCalculateButton.Location = new System.Drawing.Point(36, 214);
            this.scoreCalculateButton.Name = "scoreCalculateButton";
            this.scoreCalculateButton.Size = new System.Drawing.Size(126, 23);
            this.scoreCalculateButton.TabIndex = 12;
            this.scoreCalculateButton.Text = "Hesapla";
            this.scoreCalculateButton.UseVisualStyleBackColor = true;
            this.scoreCalculateButton.Click += new System.EventHandler(this.scoreCalculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ortalama Gider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Çalışma Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // txtbxExpense
            // 
            this.txtbxExpense.Location = new System.Drawing.Point(90, 174);
            this.txtbxExpense.Name = "txtbxExpense";
            this.txtbxExpense.Size = new System.Drawing.Size(100, 20);
            this.txtbxExpense.TabIndex = 5;
            this.txtbxExpense.Leave += new System.EventHandler(this.txtbxExpense_Leave);
            // 
            // txtbxWorkYear
            // 
            this.txtbxWorkYear.Location = new System.Drawing.Point(90, 148);
            this.txtbxWorkYear.Name = "txtbxWorkYear";
            this.txtbxWorkYear.Size = new System.Drawing.Size(100, 20);
            this.txtbxWorkYear.TabIndex = 4;
            this.txtbxWorkYear.Leave += new System.EventHandler(this.txtbxWorkYear_Leave);
            // 
            // txtbxIncome
            // 
            this.txtbxIncome.Location = new System.Drawing.Point(90, 122);
            this.txtbxIncome.Name = "txtbxIncome";
            this.txtbxIncome.Size = new System.Drawing.Size(100, 20);
            this.txtbxIncome.TabIndex = 3;
            this.txtbxIncome.Leave += new System.EventHandler(this.txtbxIncome_Leave);
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(90, 96);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(100, 20);
            this.txtbxAge.TabIndex = 2;
            this.txtbxAge.Leave += new System.EventHandler(this.txtbxAge_Leave);
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(90, 70);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtbxSurname.TabIndex = 1;
            this.txtbxSurname.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(90, 44);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 0;
            this.txtbxName.TextChanged += new System.EventHandler(this.nameChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.chckbxIsImarli);
            this.tabPage2.Controls.Add(this.chckbxIsNew);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtbxhouseAge);
            this.tabPage2.Controls.Add(this.creditCalculate);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtbxAmount);
            this.tabPage2.Controls.Add(this.txtbxMaturity);
            this.tabPage2.Controls.Add(this.txtbxCreditScore);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kredi Hesaplama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnKurumsal);
            this.groupBox1.Controls.Add(this.rdbtnBireysel);
            this.groupBox1.Location = new System.Drawing.Point(189, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 48);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rdbtnKurumsal
            // 
            this.rdbtnKurumsal.AutoSize = true;
            this.rdbtnKurumsal.Location = new System.Drawing.Point(119, 19);
            this.rdbtnKurumsal.Name = "rdbtnKurumsal";
            this.rdbtnKurumsal.Size = new System.Drawing.Size(68, 17);
            this.rdbtnKurumsal.TabIndex = 1;
            this.rdbtnKurumsal.TabStop = true;
            this.rdbtnKurumsal.Text = "Kurumsal";
            this.rdbtnKurumsal.UseVisualStyleBackColor = true;
            // 
            // rdbtnBireysel
            // 
            this.rdbtnBireysel.AutoSize = true;
            this.rdbtnBireysel.Location = new System.Drawing.Point(15, 19);
            this.rdbtnBireysel.Name = "rdbtnBireysel";
            this.rdbtnBireysel.Size = new System.Drawing.Size(61, 17);
            this.rdbtnBireysel.TabIndex = 0;
            this.rdbtnBireysel.TabStop = true;
            this.rdbtnBireysel.Text = "Bireysel";
            this.rdbtnBireysel.UseVisualStyleBackColor = true;
            // 
            // chckbxIsImarli
            // 
            this.chckbxIsImarli.AutoSize = true;
            this.chckbxIsImarli.Location = new System.Drawing.Point(189, 157);
            this.chckbxIsImarli.Name = "chckbxIsImarli";
            this.chckbxIsImarli.Size = new System.Drawing.Size(69, 17);
            this.chckbxIsImarli.TabIndex = 21;
            this.chckbxIsImarli.Text = "İmarlı mı?";
            this.chckbxIsImarli.UseVisualStyleBackColor = true;
            // 
            // chckbxIsNew
            // 
            this.chckbxIsNew.AutoSize = true;
            this.chckbxIsNew.Location = new System.Drawing.Point(189, 134);
            this.chckbxIsNew.Name = "chckbxIsNew";
            this.chckbxIsNew.Size = new System.Drawing.Size(62, 17);
            this.chckbxIsNew.TabIndex = 20;
            this.chckbxIsNew.Text = "Sıfır mı?";
            this.chckbxIsNew.UseVisualStyleBackColor = true;
            this.chckbxIsNew.CheckedChanged += new System.EventHandler(this.chckbxIsNew_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Kredi Türleri";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(286, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Bina Yaşı :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Vade :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstallmentID,
            this.LastPaymentDate,
            this.InstallmentAmount,
            this.RemainingAmount});
            this.dataGridView1.Location = new System.Drawing.Point(88, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // InstallmentID
            // 
            this.InstallmentID.HeaderText = "Taksit Sıra No";
            this.InstallmentID.Name = "InstallmentID";
            // 
            // LastPaymentDate
            // 
            this.LastPaymentDate.HeaderText = "Ödeme Tarihi";
            this.LastPaymentDate.Name = "LastPaymentDate";
            // 
            // InstallmentAmount
            // 
            this.InstallmentAmount.HeaderText = "Tutar";
            this.InstallmentAmount.Name = "InstallmentAmount";
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.HeaderText = "Kalan Tutar";
            this.RemainingAmount.Name = "RemainingAmount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Tutar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kredi Skoru :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 12;
            // 
            // txtbxhouseAge
            // 
            this.txtbxhouseAge.Location = new System.Drawing.Point(260, 134);
            this.txtbxhouseAge.Name = "txtbxhouseAge";
            this.txtbxhouseAge.Size = new System.Drawing.Size(100, 20);
            this.txtbxhouseAge.TabIndex = 11;
            // 
            // creditCalculate
            // 
            this.creditCalculate.Location = new System.Drawing.Point(443, 42);
            this.creditCalculate.Name = "creditCalculate";
            this.creditCalculate.Size = new System.Drawing.Size(161, 61);
            this.creditCalculate.TabIndex = 8;
            this.creditCalculate.Text = "HESAPLA";
            this.creditCalculate.UseVisualStyleBackColor = true;
            this.creditCalculate.Click += new System.EventHandler(this.creditCalculate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 6;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 5;
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(260, 63);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtbxAmount.TabIndex = 4;
            // 
            // txtbxMaturity
            // 
            this.txtbxMaturity.Location = new System.Drawing.Point(260, 96);
            this.txtbxMaturity.Name = "txtbxMaturity";
            this.txtbxMaturity.Size = new System.Drawing.Size(100, 20);
            this.txtbxMaturity.TabIndex = 3;
            // 
            // txtbxCreditScore
            // 
            this.txtbxCreditScore.Enabled = false;
            this.txtbxCreditScore.Location = new System.Drawing.Point(260, 25);
            this.txtbxCreditScore.Name = "txtbxCreditScore";
            this.txtbxCreditScore.Size = new System.Drawing.Size(100, 20);
            this.txtbxCreditScore.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Taşıt Kredisi",
            "Konut Kredisi",
            "İhtiyaç Kredisi",
            "Arsa Kredisi"});
            this.listBox1.Location = new System.Drawing.Point(23, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 499);
            this.Controls.Add(this.accountTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.accountTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl accountTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxExpense;
        private System.Windows.Forms.TextBox txtbxWorkYear;
        private System.Windows.Forms.TextBox txtbxIncome;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button scoreCalculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbxhouseAge;
        private System.Windows.Forms.Button creditCalculate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.TextBox txtbxMaturity;
        private System.Windows.Forms.TextBox txtbxCreditScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chckbxIsImarli;
        private System.Windows.Forms.CheckBox chckbxIsNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnKurumsal;
        private System.Windows.Forms.RadioButton rdbtnBireysel;
        private System.Windows.Forms.Label scoreResultLabel;
    }
}

