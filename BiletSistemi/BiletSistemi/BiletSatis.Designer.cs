namespace BiletSistemi {
    partial class BiletSatis {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.btnBiletYarat = new System.Windows.Forms.Button();
            this.cmbBiletAdet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilet Satış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nereden : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nereye : ";
            // 
            // cmbNereden
            // 
            this.cmbNereden.AllowDrop = true;
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(123, 69);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(121, 21);
            this.cmbNereden.TabIndex = 6;
            // 
            // cmbNereye
            // 
            this.cmbNereye.AllowDrop = true;
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(123, 97);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(121, 21);
            this.cmbNereye.TabIndex = 7;
            // 
            // btnBiletYarat
            // 
            this.btnBiletYarat.Location = new System.Drawing.Point(63, 149);
            this.btnBiletYarat.Name = "btnBiletYarat";
            this.btnBiletYarat.Size = new System.Drawing.Size(181, 23);
            this.btnBiletYarat.TabIndex = 8;
            this.btnBiletYarat.Text = "Bilet Üret";
            this.btnBiletYarat.UseVisualStyleBackColor = true;
            this.btnBiletYarat.Click += new System.EventHandler(this.btnBiletYarat_Click);
            // 
            // cmbBiletAdet
            // 
            this.cmbBiletAdet.AllowDrop = true;
            this.cmbBiletAdet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiletAdet.FormattingEnabled = true;
            this.cmbBiletAdet.Location = new System.Drawing.Point(123, 122);
            this.cmbBiletAdet.Name = "cmbBiletAdet";
            this.cmbBiletAdet.Size = new System.Drawing.Size(121, 21);
            this.cmbBiletAdet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilet Adet : ";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(63, 179);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(181, 23);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // BiletSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(293, 220);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.cmbBiletAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBiletYarat);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BiletSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletSatis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbNereden;
        public System.Windows.Forms.ComboBox cmbNereye;
        public System.Windows.Forms.Button btnBiletYarat;
        public System.Windows.Forms.ComboBox cmbBiletAdet;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKapat;
    }
}