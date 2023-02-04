namespace UI_Layerr
{
    partial class KayitDevamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitDevamForm));
            this.cmb_Aktivite = new RJCodeAdvance.RJControls.RJComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_HedefSecim = new RJCodeAdvance.RJControls.RJComboBox();
            this.btn_Kaydet = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Aktivite
            // 
            this.cmb_Aktivite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Aktivite.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_Aktivite.BorderSize = 1;
            this.cmb_Aktivite.DisplayMember = "Çok Az (Hareket etmiyorum veya çok az hareket ediyorum.)";
            this.cmb_Aktivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_Aktivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_Aktivite.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Aktivite.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_Aktivite.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_Aktivite.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_Aktivite.Location = new System.Drawing.Point(12, 50);
            this.cmb_Aktivite.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_Aktivite.Name = "cmb_Aktivite";
            this.cmb_Aktivite.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_Aktivite.Size = new System.Drawing.Size(606, 30);
            this.cmb_Aktivite.TabIndex = 28;
            this.cmb_Aktivite.Texts = "Aktivite Düzeyi Seçiniz";
            this.cmb_Aktivite.ValueMember = "Çok Az (Hareket etmiyorum veya çok az hareket ediyorum.)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_HedefSecim
            // 
            this.cmb_HedefSecim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_HedefSecim.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_HedefSecim.BorderSize = 1;
            this.cmb_HedefSecim.DisplayMember = "Çok Az (Hareket etmiyorum veya çok az hareket ediyorum.)";
            this.cmb_HedefSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_HedefSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_HedefSecim.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_HedefSecim.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_HedefSecim.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_HedefSecim.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_HedefSecim.Location = new System.Drawing.Point(12, 97);
            this.cmb_HedefSecim.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_HedefSecim.Name = "cmb_HedefSecim";
            this.cmb_HedefSecim.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_HedefSecim.Size = new System.Drawing.Size(606, 30);
            this.cmb_HedefSecim.TabIndex = 29;
            this.cmb_HedefSecim.Texts = "Hedef Seçiniz";
            this.cmb_HedefSecim.ValueMember = "Çok Az (Hareket etmiyorum veya çok az hareket ediyorum.)";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Kaydet.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Kaydet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Kaydet.BorderRadius = 0;
            this.btn_Kaydet.BorderSize = 0;
            this.btn_Kaydet.FlatAppearance.BorderSize = 0;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(13, 237);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(606, 47);
            this.btn_Kaydet.TabIndex = 30;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextColor = System.Drawing.Color.White;
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // KayitDevamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 437);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cmb_HedefSecim);
            this.Controls.Add(this.cmb_Aktivite);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KayitDevamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.KayitDevamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJComboBox cmb_Aktivite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJComboBox cmb_HedefSecim;
        private RJCodeAdvance.RJControls.RJButton btn_Kaydet;
    }
}