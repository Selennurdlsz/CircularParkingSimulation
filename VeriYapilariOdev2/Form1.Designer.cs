namespace VeriYapilariOdev2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.btnArabaCikar = new System.Windows.Forms.Button();
            this.lblAracEkle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.BackColor = System.Drawing.Color.Aquamarine;
            this.btnArabaEkle.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabaEkle.Location = new System.Drawing.Point(536, 102);
            this.btnArabaEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(192, 132);
            this.btnArabaEkle.TabIndex = 0;
            this.btnArabaEkle.Text = "Araba Ekle";
            this.btnArabaEkle.UseVisualStyleBackColor = false;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // btnArabaCikar
            // 
            this.btnArabaCikar.BackColor = System.Drawing.Color.LightPink;
            this.btnArabaCikar.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabaCikar.Location = new System.Drawing.Point(536, 250);
            this.btnArabaCikar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArabaCikar.Name = "btnArabaCikar";
            this.btnArabaCikar.Size = new System.Drawing.Size(192, 132);
            this.btnArabaCikar.TabIndex = 1;
            this.btnArabaCikar.Text = "Araba Çıkar";
            this.btnArabaCikar.UseVisualStyleBackColor = false;
            this.btnArabaCikar.Visible = false;
            this.btnArabaCikar.Click += new System.EventHandler(this.btnArabaCikar_Click);
            // 
            // lblAracEkle
            // 
            this.lblAracEkle.AutoSize = true;
            this.lblAracEkle.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAracEkle.Location = new System.Drawing.Point(369, 48);
            this.lblAracEkle.Name = "lblAracEkle";
            this.lblAracEkle.Size = new System.Drawing.Size(319, 25);
            this.lblAracEkle.TabIndex = 2;
            this.lblAracEkle.Text = "Lütfen Once Arac Ekleyiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 463);
            this.Controls.Add(this.lblAracEkle);
            this.Controls.Add(this.btnArabaCikar);
            this.Controls.Add(this.btnArabaEkle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Yığın, Dairesel Bağlı Liste ve Kuyruk Tabanlı Otopark Benzetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Button btnArabaCikar;
        private System.Windows.Forms.Label lblAracEkle;
    }
}

