namespace UI_Layerr
{
    partial class frm_KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KayitOl));
            this.btn_ResimEkle = new System.Windows.Forms.Button();
            this.btn_KayıtOl = new System.Windows.Forms.Button();
            this.cmb_boy = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_DogumTarihi = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_DogumTarihi = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cmb_kilo = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Cinsiyet = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Parola = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ePosta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Soyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Ad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rdo_Erkek = new RJCodeAdvance.RJControls.RJRadioButton();
            this.Rdo_Kadın = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ResimEkle
            // 
            this.btn_ResimEkle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_ResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ResimEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ResimEkle.Location = new System.Drawing.Point(0, 199);
            this.btn_ResimEkle.Name = "btn_ResimEkle";
            this.btn_ResimEkle.Size = new System.Drawing.Size(194, 36);
            this.btn_ResimEkle.TabIndex = 42;
            this.btn_ResimEkle.Text = "RESİM EKLE";
            this.btn_ResimEkle.UseVisualStyleBackColor = false;
            // 
            // btn_KayıtOl
            // 
            this.btn_KayıtOl.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_KayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayıtOl.ForeColor = System.Drawing.Color.Transparent;
            this.btn_KayıtOl.Location = new System.Drawing.Point(0, 241);
            this.btn_KayıtOl.Name = "btn_KayıtOl";
            this.btn_KayıtOl.Size = new System.Drawing.Size(194, 39);
            this.btn_KayıtOl.TabIndex = 41;
            this.btn_KayıtOl.Text = "KAYITA DEVAM ET";
            this.btn_KayıtOl.UseVisualStyleBackColor = false;
            this.btn_KayıtOl.Click += new System.EventHandler(this.btn_KayıtOl_Click);
            // 
            // cmb_boy
            // 
            this.cmb_boy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_boy.FormattingEnabled = true;
            this.cmb_boy.Items.AddRange(new object[] {
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230"});
            this.cmb_boy.Location = new System.Drawing.Point(477, 250);
            this.cmb_boy.Name = "cmb_boy";
            this.cmb_boy.Size = new System.Drawing.Size(137, 24);
            this.cmb_boy.TabIndex = 40;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(370, 248);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 26);
            this.materialLabel4.TabIndex = 39;
            this.materialLabel4.Text = "BOY (CM)";
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DogumTarihi.Depth = 0;
            this.lbl_DogumTarihi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_DogumTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(189, 99);
            this.lbl_DogumTarihi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(199, 31);
            this.lbl_DogumTarihi.TabIndex = 38;
            this.lbl_DogumTarihi.Text = "DOĞUM TARİHİ";
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DogumTarihi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_DogumTarihi.BorderSize = 0;
            this.dtp_DogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(189, 135);
            this.dtp_DogumTarihi.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(199, 35);
            this.dtp_DogumTarihi.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_DogumTarihi.TabIndex = 37;
            this.dtp_DogumTarihi.TextColor = System.Drawing.Color.White;
            // 
            // cmb_kilo
            // 
            this.cmb_kilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_kilo.FormattingEnabled = true;
            this.cmb_kilo.Items.AddRange(new object[] {
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230"});
            this.cmb_kilo.Location = new System.Drawing.Point(477, 196);
            this.cmb_kilo.Name = "cmb_kilo";
            this.cmb_kilo.Size = new System.Drawing.Size(137, 24);
            this.cmb_kilo.TabIndex = 36;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(370, 196);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 24);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "KİLO (KG)";
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cinsiyet.Depth = 0;
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Cinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(412, 99);
            this.lbl_Cinsiyet.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(202, 31);
            this.lbl_Cinsiyet.TabIndex = 33;
            this.lbl_Cinsiyet.Text = "CİNSİYET";
            // 
            // txt_Parola
            // 
            this.txt_Parola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Parola.Depth = 0;
            this.txt_Parola.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Parola.Hint = "";
            this.txt_Parola.Location = new System.Drawing.Point(416, 56);
            this.txt_Parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '\0';
            this.txt_Parola.SelectedText = "";
            this.txt_Parola.SelectionLength = 0;
            this.txt_Parola.SelectionStart = 0;
            this.txt_Parola.Size = new System.Drawing.Size(199, 28);
            this.txt_Parola.TabIndex = 31;
            this.txt_Parola.Text = "PAROLA";
            this.txt_Parola.UseSystemPasswordChar = false;
            this.txt_Parola.Click += new System.EventHandler(this.txt_Parola_Click);
            // 
            // txt_ePosta
            // 
            this.txt_ePosta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ePosta.Depth = 0;
            this.txt_ePosta.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ePosta.Hint = "";
            this.txt_ePosta.Location = new System.Drawing.Point(189, 56);
            this.txt_ePosta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ePosta.Name = "txt_ePosta";
            this.txt_ePosta.PasswordChar = '\0';
            this.txt_ePosta.SelectedText = "";
            this.txt_ePosta.SelectionLength = 0;
            this.txt_ePosta.SelectionStart = 0;
            this.txt_ePosta.Size = new System.Drawing.Size(199, 28);
            this.txt_ePosta.TabIndex = 30;
            this.txt_ePosta.Text = "E-POSTA ";
            this.txt_ePosta.UseSystemPasswordChar = false;
            this.txt_ePosta.Click += new System.EventHandler(this.txt_ePosta_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Soyad.Depth = 0;
            this.txt_Soyad.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Soyad.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Soyad.Hint = "";
            this.txt_Soyad.Location = new System.Drawing.Point(416, 13);
            this.txt_Soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.PasswordChar = '\0';
            this.txt_Soyad.SelectedText = "";
            this.txt_Soyad.SelectionLength = 0;
            this.txt_Soyad.SelectionStart = 0;
            this.txt_Soyad.Size = new System.Drawing.Size(199, 28);
            this.txt_Soyad.TabIndex = 29;
            this.txt_Soyad.Text = "SOYAD";
            this.txt_Soyad.UseSystemPasswordChar = false;
            this.txt_Soyad.Click += new System.EventHandler(this.txt_Soyad_Click);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Ad.Depth = 0;
            this.txt_Ad.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ad.Hint = "";
            this.txt_Ad.Location = new System.Drawing.Point(189, 13);
            this.txt_Ad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.PasswordChar = '\0';
            this.txt_Ad.SelectedText = "";
            this.txt_Ad.SelectionLength = 0;
            this.txt_Ad.SelectionStart = 0;
            this.txt_Ad.Size = new System.Drawing.Size(199, 28);
            this.txt_Ad.TabIndex = 28;
            this.txt_Ad.Text = "AD";
            this.txt_Ad.UseSystemPasswordChar = false;
            this.txt_Ad.Click += new System.EventHandler(this.txt_Ad_Click);
            // 
            // Rdo_Erkek
            // 
            this.Rdo_Erkek.AutoSize = true;
            this.Rdo_Erkek.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.Rdo_Erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rdo_Erkek.Location = new System.Drawing.Point(413, 141);
            this.Rdo_Erkek.MinimumSize = new System.Drawing.Size(0, 21);
            this.Rdo_Erkek.Name = "Rdo_Erkek";
            this.Rdo_Erkek.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Rdo_Erkek.Size = new System.Drawing.Size(82, 24);
            this.Rdo_Erkek.TabIndex = 43;
            this.Rdo_Erkek.TabStop = true;
            this.Rdo_Erkek.Text = "Erkek";
            this.Rdo_Erkek.UnCheckedColor = System.Drawing.Color.Gray;
            this.Rdo_Erkek.UseVisualStyleBackColor = true;
            // 
            // Rdo_Kadın
            // 
            this.Rdo_Kadın.AutoSize = true;
            this.Rdo_Kadın.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.Rdo_Kadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rdo_Kadın.Location = new System.Drawing.Point(527, 140);
            this.Rdo_Kadın.MinimumSize = new System.Drawing.Size(0, 21);
            this.Rdo_Kadın.Name = "Rdo_Kadın";
            this.Rdo_Kadın.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Rdo_Kadın.Size = new System.Drawing.Size(82, 24);
            this.Rdo_Kadın.TabIndex = 44;
            this.Rdo_Kadın.TabStop = true;
            this.Rdo_Kadın.Text = "Kadın";
            this.Rdo_Kadın.UnCheckedColor = System.Drawing.Color.Gray;
            this.Rdo_Kadın.UseVisualStyleBackColor = true;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(183, 183);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 27;
            this.rjCircularPictureBox1.TabStop = false;
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
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frm_KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 437);
            this.Controls.Add(this.Rdo_Kadın);
            this.Controls.Add(this.Rdo_Erkek);
            this.Controls.Add(this.btn_ResimEkle);
            this.Controls.Add(this.btn_KayıtOl);
            this.Controls.Add(this.cmb_boy);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lbl_DogumTarihi);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.cmb_kilo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lbl_Cinsiyet);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_ePosta);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ResimEkle;
        private System.Windows.Forms.Button btn_KayıtOl;
        private System.Windows.Forms.ComboBox cmb_boy;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_DogumTarihi;
        private RJCodeAdvance.RJControls.RJDatePicker dtp_DogumTarihi;
        private System.Windows.Forms.ComboBox cmb_kilo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_Cinsiyet;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Parola;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ePosta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Soyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Ad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJRadioButton Rdo_Erkek;
        private RJCodeAdvance.RJControls.RJRadioButton Rdo_Kadın;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}