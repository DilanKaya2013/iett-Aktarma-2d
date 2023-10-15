namespace iett_deneme
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
            this.grbAktarmalar = new System.Windows.Forms.GroupBox();
            this.drbBakiyeyukleme = new System.Windows.Forms.GroupBox();
            this.rbIlkbinis = new System.Windows.Forms.RadioButton();
            this.rbAktarma1 = new System.Windows.Forms.RadioButton();
            this.rbAktarma2 = new System.Windows.Forms.RadioButton();
            this.rbAktarma3 = new System.Windows.Forms.RadioButton();
            this.rbAktarma4 = new System.Windows.Forms.RadioButton();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.chbOgrenci = new System.Windows.Forms.CheckBox();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnYukle20 = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnYukle50 = new System.Windows.Forms.Button();
            this.btnYukle200 = new System.Windows.Forms.Button();
            this.btnYukle100 = new System.Windows.Forms.Button();
            this.btnYukle500 = new System.Windows.Forms.Button();
            this.grbAktarmalar.SuspendLayout();
            this.drbBakiyeyukleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAktarmalar
            // 
            this.grbAktarmalar.Controls.Add(this.chbOgrenci);
            this.grbAktarmalar.Controls.Add(this.rbAktarma4);
            this.grbAktarmalar.Controls.Add(this.rbAktarma3);
            this.grbAktarmalar.Controls.Add(this.rbAktarma2);
            this.grbAktarmalar.Controls.Add(this.rbAktarma1);
            this.grbAktarmalar.Controls.Add(this.rbIlkbinis);
            this.grbAktarmalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbAktarmalar.Location = new System.Drawing.Point(17, 138);
            this.grbAktarmalar.Name = "grbAktarmalar";
            this.grbAktarmalar.Size = new System.Drawing.Size(154, 301);
            this.grbAktarmalar.TabIndex = 0;
            this.grbAktarmalar.TabStop = false;
            this.grbAktarmalar.Text = "Aktarmalar";
            this.grbAktarmalar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // drbBakiyeyukleme
            // 
            this.drbBakiyeyukleme.Controls.Add(this.btnYukle500);
            this.drbBakiyeyukleme.Controls.Add(this.btnYukle100);
            this.drbBakiyeyukleme.Controls.Add(this.btnYukle200);
            this.drbBakiyeyukleme.Controls.Add(this.btnYukle50);
            this.drbBakiyeyukleme.Controls.Add(this.btnYukle20);
            this.drbBakiyeyukleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drbBakiyeyukleme.Location = new System.Drawing.Point(200, 138);
            this.drbBakiyeyukleme.Name = "drbBakiyeyukleme";
            this.drbBakiyeyukleme.Size = new System.Drawing.Size(193, 301);
            this.drbBakiyeyukleme.TabIndex = 1;
            this.drbBakiyeyukleme.TabStop = false;
            this.drbBakiyeyukleme.Text = "Bakiye Yükleme";
            // 
            // rbIlkbinis
            // 
            this.rbIlkbinis.AutoSize = true;
            this.rbIlkbinis.Location = new System.Drawing.Point(16, 42);
            this.rbIlkbinis.Name = "rbIlkbinis";
            this.rbIlkbinis.Size = new System.Drawing.Size(70, 20);
            this.rbIlkbinis.TabIndex = 0;
            this.rbIlkbinis.TabStop = true;
            this.rbIlkbinis.Text = "İlk Biniş";
            this.rbIlkbinis.UseVisualStyleBackColor = true;
            // 
            // rbAktarma1
            // 
            this.rbAktarma1.AutoSize = true;
            this.rbAktarma1.Location = new System.Drawing.Point(16, 77);
            this.rbAktarma1.Name = "rbAktarma1";
            this.rbAktarma1.Size = new System.Drawing.Size(85, 20);
            this.rbAktarma1.TabIndex = 1;
            this.rbAktarma1.TabStop = true;
            this.rbAktarma1.Text = "1.Aktarma";
            this.rbAktarma1.UseVisualStyleBackColor = true;
            // 
            // rbAktarma2
            // 
            this.rbAktarma2.AutoSize = true;
            this.rbAktarma2.Location = new System.Drawing.Point(16, 112);
            this.rbAktarma2.Name = "rbAktarma2";
            this.rbAktarma2.Size = new System.Drawing.Size(85, 20);
            this.rbAktarma2.TabIndex = 2;
            this.rbAktarma2.TabStop = true;
            this.rbAktarma2.Text = "2.Aktarma";
            this.rbAktarma2.UseVisualStyleBackColor = true;
            // 
            // rbAktarma3
            // 
            this.rbAktarma3.AutoSize = true;
            this.rbAktarma3.Location = new System.Drawing.Point(16, 147);
            this.rbAktarma3.Name = "rbAktarma3";
            this.rbAktarma3.Size = new System.Drawing.Size(85, 20);
            this.rbAktarma3.TabIndex = 3;
            this.rbAktarma3.TabStop = true;
            this.rbAktarma3.Text = "3.Aktarma";
            this.rbAktarma3.UseVisualStyleBackColor = true;
            // 
            // rbAktarma4
            // 
            this.rbAktarma4.AutoSize = true;
            this.rbAktarma4.Location = new System.Drawing.Point(16, 182);
            this.rbAktarma4.Name = "rbAktarma4";
            this.rbAktarma4.Size = new System.Drawing.Size(85, 20);
            this.rbAktarma4.TabIndex = 4;
            this.rbAktarma4.TabStop = true;
            this.rbAktarma4.Text = "4.Aktarma";
            this.rbAktarma4.UseVisualStyleBackColor = true;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(14, 29);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(52, 18);
            this.lblBakiye.TabIndex = 2;
            this.lblBakiye.Text = "Bakiye";
            // 
            // chbOgrenci
            // 
            this.chbOgrenci.AutoSize = true;
            this.chbOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbOgrenci.Location = new System.Drawing.Point(16, 218);
            this.chbOgrenci.Name = "chbOgrenci";
            this.chbOgrenci.Size = new System.Drawing.Size(80, 20);
            this.chbOgrenci.TabIndex = 5;
            this.chbOgrenci.Text = "Öğrenci";
            this.chbOgrenci.UseVisualStyleBackColor = true;
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.Color.White;
            this.btnOdeme.Location = new System.Drawing.Point(200, 29);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(193, 62);
            this.btnOdeme.TabIndex = 3;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnYukle20
            // 
            this.btnYukle20.BackColor = System.Drawing.Color.Fuchsia;
            this.btnYukle20.Location = new System.Drawing.Point(21, 42);
            this.btnYukle20.Name = "btnYukle20";
            this.btnYukle20.Size = new System.Drawing.Size(152, 31);
            this.btnYukle20.TabIndex = 0;
            this.btnYukle20.Text = "20₺ Yükle";
            this.btnYukle20.UseVisualStyleBackColor = false;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.Color.Crimson;
            this.lblMiktar.Location = new System.Drawing.Point(12, 62);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(55, 29);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "200";
            // 
            // btnYukle50
            // 
            this.btnYukle50.BackColor = System.Drawing.Color.Orchid;
            this.btnYukle50.Location = new System.Drawing.Point(20, 81);
            this.btnYukle50.Name = "btnYukle50";
            this.btnYukle50.Size = new System.Drawing.Size(155, 31);
            this.btnYukle50.TabIndex = 1;
            this.btnYukle50.Text = "50₺ Yükle";
            this.btnYukle50.UseVisualStyleBackColor = false;
            // 
            // btnYukle200
            // 
            this.btnYukle200.BackColor = System.Drawing.Color.DeepPink;
            this.btnYukle200.Location = new System.Drawing.Point(20, 159);
            this.btnYukle200.Name = "btnYukle200";
            this.btnYukle200.Size = new System.Drawing.Size(155, 31);
            this.btnYukle200.TabIndex = 2;
            this.btnYukle200.Text = "200₺ Yükle";
            this.btnYukle200.UseVisualStyleBackColor = false;
            // 
            // btnYukle100
            // 
            this.btnYukle100.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnYukle100.Location = new System.Drawing.Point(20, 120);
            this.btnYukle100.Name = "btnYukle100";
            this.btnYukle100.Size = new System.Drawing.Size(155, 31);
            this.btnYukle100.TabIndex = 3;
            this.btnYukle100.Text = "100₺ Yükle";
            this.btnYukle100.UseVisualStyleBackColor = false;
            // 
            // btnYukle500
            // 
            this.btnYukle500.BackColor = System.Drawing.Color.HotPink;
            this.btnYukle500.Location = new System.Drawing.Point(20, 198);
            this.btnYukle500.Name = "btnYukle500";
            this.btnYukle500.Size = new System.Drawing.Size(155, 31);
            this.btnYukle500.TabIndex = 4;
            this.btnYukle500.Text = "500₺ Yükle";
            this.btnYukle500.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 463);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.drbBakiyeyukleme);
            this.Controls.Add(this.grbAktarmalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbAktarmalar.ResumeLayout(false);
            this.grbAktarmalar.PerformLayout();
            this.drbBakiyeyukleme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAktarmalar;
        private System.Windows.Forms.GroupBox drbBakiyeyukleme;
        private System.Windows.Forms.CheckBox chbOgrenci;
        private System.Windows.Forms.RadioButton rbAktarma4;
        private System.Windows.Forms.RadioButton rbAktarma3;
        private System.Windows.Forms.RadioButton rbAktarma2;
        private System.Windows.Forms.RadioButton rbAktarma1;
        private System.Windows.Forms.RadioButton rbIlkbinis;
        private System.Windows.Forms.Button btnYukle500;
        private System.Windows.Forms.Button btnYukle100;
        private System.Windows.Forms.Button btnYukle200;
        private System.Windows.Forms.Button btnYukle50;
        private System.Windows.Forms.Button btnYukle20;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label lblMiktar;
    }
}

