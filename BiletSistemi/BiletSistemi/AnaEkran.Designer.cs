namespace BiletSistemi {
    partial class AnaEkran {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.btnBiletIade = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(98, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Ekran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "---------------------------";
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.Location = new System.Drawing.Point(102, 125);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Size = new System.Drawing.Size(75, 23);
            this.btnBiletSatis.TabIndex = 2;
            this.btnBiletSatis.Text = "Bilet Satış";
            this.btnBiletSatis.UseVisualStyleBackColor = true;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // btnBiletIade
            // 
            this.btnBiletIade.Location = new System.Drawing.Point(102, 164);
            this.btnBiletIade.Name = "btnBiletIade";
            this.btnBiletIade.Size = new System.Drawing.Size(75, 23);
            this.btnBiletIade.TabIndex = 3;
            this.btnBiletIade.Text = "Bilet İade";
            this.btnBiletIade.Click += new System.EventHandler( this.btnBiletIade_Click );
            this.btnBiletIade.UseVisualStyleBackColor = true;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTarih.Location = new System.Drawing.Point(197, 34);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 13);
            this.lblTarih.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSaat.Location = new System.Drawing.Point(20, 34);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 20);
            this.lblSaat.TabIndex = 6;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(102, 204);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(302, 281);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnBiletIade);
            this.Controls.Add(this.btnBiletSatis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBiletSatis;
        public System.Windows.Forms.Button btnBiletIade;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblSaat;
        public System.Windows.Forms.Button btnKapat;
    }
}

