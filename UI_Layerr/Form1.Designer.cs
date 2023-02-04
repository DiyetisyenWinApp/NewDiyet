namespace UI_Layerr
{
    partial class frm_GirisYap
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
            this.btn_Kayit = new RJCodeAdvance.RJControls.RJButton();
            this.btn_Giris = new RJCodeAdvance.RJControls.RJButton();
            this.txt_Parola = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ePosta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kayit.BackColor = System.Drawing.Color.Black;
            this.btn_Kayit.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Kayit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Kayit.BorderRadius = 0;
            this.btn_Kayit.BorderSize = 0;
            this.btn_Kayit.FlatAppearance.BorderSize = 0;
            this.btn_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kayit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Kayit.Location = new System.Drawing.Point(445, 303);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(154, 27);
            this.btn_Kayit.TabIndex = 24;
            this.btn_Kayit.Text = "KAYIT OL";
            this.btn_Kayit.TextColor = System.Drawing.Color.Transparent;
            this.btn_Kayit.UseVisualStyleBackColor = false;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // btn_Giris
            // 
            this.btn_Giris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Giris.BackColor = System.Drawing.Color.Black;
            this.btn_Giris.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Giris.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Giris.BorderRadius = 0;
            this.btn_Giris.BorderSize = 0;
            this.btn_Giris.FlatAppearance.BorderSize = 0;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(445, 244);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(154, 40);
            this.btn_Giris.TabIndex = 23;
            this.btn_Giris.Text = "GİRİŞ YAP";
            this.btn_Giris.TextColor = System.Drawing.Color.White;
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Parola.Depth = 0;
            this.txt_Parola.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Parola.Hint = "";
            this.txt_Parola.Location = new System.Drawing.Point(396, 180);
            this.txt_Parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '\0';
            this.txt_Parola.SelectedText = "";
            this.txt_Parola.SelectionLength = 0;
            this.txt_Parola.SelectionStart = 0;
            this.txt_Parola.Size = new System.Drawing.Size(195, 28);
            this.txt_Parola.TabIndex = 22;
            this.txt_Parola.Text = "PAROLA";
            this.txt_Parola.UseSystemPasswordChar = false;
            this.txt_Parola.Click += new System.EventHandler(this.txt_Parola_Click);
            // 
            // txt_ePosta
            // 
            this.txt_ePosta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ePosta.Depth = 0;
            this.txt_ePosta.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ePosta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_ePosta.Hint = "";
            this.txt_ePosta.Location = new System.Drawing.Point(396, 130);
            this.txt_ePosta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ePosta.Name = "txt_ePosta";
            this.txt_ePosta.PasswordChar = '\0';
            this.txt_ePosta.SelectedText = "";
            this.txt_ePosta.SelectionLength = 0;
            this.txt_ePosta.SelectionStart = 0;
            this.txt_ePosta.Size = new System.Drawing.Size(195, 28);
            this.txt_ePosta.TabIndex = 21;
            this.txt_ePosta.Text = "E-posta";
            this.txt_ePosta.UseSystemPasswordChar = false;
            this.txt_ePosta.Click += new System.EventHandler(this.txt_ePosta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::UI_Layerr.Properties.Resources.Sağlıklı_Yemek_Menüsü;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frm_GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_ePosta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton btn_Kayit;
        private RJCodeAdvance.RJControls.RJButton btn_Giris;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Parola;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ePosta;
    }
}

