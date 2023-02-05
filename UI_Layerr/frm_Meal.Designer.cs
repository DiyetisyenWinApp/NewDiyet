namespace UI_Layerr
{
    partial class frm_Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Meal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_Ogun = new RJCodeAdvance.RJControls.RJComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbx_Yemekler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 238);
            this.dataGridView1.TabIndex = 30;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(57, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 23);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Öğün";
            // 
            // cmb_Ogun
            // 
            this.cmb_Ogun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Ogun.BorderColor = System.Drawing.Color.Black;
            this.cmb_Ogun.BorderSize = 1;
            this.cmb_Ogun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_Ogun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_Ogun.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Ogun.IconColor = System.Drawing.Color.Black;
            this.cmb_Ogun.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_Ogun.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_Ogun.Location = new System.Drawing.Point(153, 12);
            this.cmb_Ogun.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_Ogun.Name = "cmb_Ogun";
            this.cmb_Ogun.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_Ogun.Size = new System.Drawing.Size(200, 30);
            this.cmb_Ogun.TabIndex = 32;
            this.cmb_Ogun.Texts = "";
            this.cmb_Ogun.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(376, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 23);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Yemek";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(388, 274);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 23);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Gram";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(456, 274);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(519, 274);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 39;
            this.rjButton1.Text = "Ekle";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Location = new System.Drawing.Point(450, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 24);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbx_Yemekler
            // 
            this.lbx_Yemekler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbx_Yemekler.FormattingEnabled = true;
            this.lbx_Yemekler.ItemHeight = 16;
            this.lbx_Yemekler.Location = new System.Drawing.Point(380, 56);
            this.lbx_Yemekler.Name = "lbx_Yemekler";
            this.lbx_Yemekler.Size = new System.Drawing.Size(289, 196);
            this.lbx_Yemekler.TabIndex = 40;
            // 
            // frm_Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbx_Yemekler);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cmb_Ogun);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Meal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Meal";
            this.Load += new System.EventHandler(this.frm_Meal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private RJCodeAdvance.RJControls.RJComboBox cmb_Ogun;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbx_Yemekler;
    }
}