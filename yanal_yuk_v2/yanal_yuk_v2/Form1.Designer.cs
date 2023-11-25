using System;
using System.Windows.Forms;

namespace yanal_yuk_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHidrolikAsagi = new System.Windows.Forms.Button();
            this.btnHidrolikYukari = new System.Windows.Forms.Button();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuHafta = new System.Windows.Forms.Button();
            this.txtUretimHaftasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMaxCapTesti = new System.Windows.Forms.CheckBox();
            this.chkKuvvetTesti = new System.Windows.Forms.CheckBox();
            this.chkYanalYukTesti = new System.Windows.Forms.CheckBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnHepsiniBaslat = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_data_debug = new System.Windows.Forms.CheckBox();
            this.chk_r = new System.Windows.Forms.CheckBox();
            this.chk_n = new System.Windows.Forms.CheckBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtGelen = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGiden = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_baglanti = new System.Windows.Forms.Label();
            this.picDurum = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDurum)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataRecieved);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kuvvet Testi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 54;
            this.label7.Text = "HİDROLİK\r\nSİLİNDİR";
            // 
            // btnHidrolikAsagi
            // 
            this.btnHidrolikAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHidrolikAsagi.Location = new System.Drawing.Point(900, 382);
            this.btnHidrolikAsagi.Name = "btnHidrolikAsagi";
            this.btnHidrolikAsagi.Size = new System.Drawing.Size(58, 27);
            this.btnHidrolikAsagi.TabIndex = 53;
            this.btnHidrolikAsagi.Text = "AŞAĞI";
            this.btnHidrolikAsagi.UseVisualStyleBackColor = true;
            this.btnHidrolikAsagi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHidrolikAsagi_MouseDown);
            this.btnHidrolikAsagi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHidrolikAsagi_MouseUp);
            // 
            // btnHidrolikYukari
            // 
            this.btnHidrolikYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHidrolikYukari.Location = new System.Drawing.Point(900, 356);
            this.btnHidrolikYukari.Name = "btnHidrolikYukari";
            this.btnHidrolikYukari.Size = new System.Drawing.Size(58, 27);
            this.btnHidrolikYukari.TabIndex = 52;
            this.btnHidrolikYukari.Text = "YUKARI";
            this.btnHidrolikYukari.UseVisualStyleBackColor = true;
            this.btnHidrolikYukari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHidrolikYukari_MouseDown);
            this.btnHidrolikYukari.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHidrolikYukari_MouseUp);
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporOlustur.Location = new System.Drawing.Point(900, 243);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(58, 20);
            this.btnRaporOlustur.TabIndex = 51;
            this.btnRaporOlustur.Text = "OLUŞTUR";
            this.btnRaporOlustur.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(812, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Rapor Numarası:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(815, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Testi Yapan:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(815, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Hafta:";
            // 
            // btnBuHafta
            // 
            this.btnBuHafta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuHafta.Location = new System.Drawing.Point(912, 311);
            this.btnBuHafta.Name = "btnBuHafta";
            this.btnBuHafta.Size = new System.Drawing.Size(46, 21);
            this.btnBuHafta.TabIndex = 45;
            this.btnBuHafta.Text = "bu hafta";
            this.btnBuHafta.UseVisualStyleBackColor = true;
            this.btnBuHafta.Click += new System.EventHandler(this.btnBuHafta_Click);
            // 
            // txtUretimHaftasi
            // 
            this.txtUretimHaftasi.Location = new System.Drawing.Point(854, 311);
            this.txtUretimHaftasi.Name = "txtUretimHaftasi";
            this.txtUretimHaftasi.Size = new System.Drawing.Size(39, 20);
            this.txtUretimHaftasi.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(815, 285);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yay Numarası:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(815, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMaxCapTesti);
            this.groupBox1.Controls.Add(this.chkKuvvetTesti);
            this.groupBox1.Controls.Add(this.chkYanalYukTesti);
            this.groupBox1.Location = new System.Drawing.Point(815, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Tipi Seçimi";
            // 
            // chkMaxCapTesti
            // 
            this.chkMaxCapTesti.AutoSize = true;
            this.chkMaxCapTesti.Location = new System.Drawing.Point(6, 65);
            this.chkMaxCapTesti.Name = "chkMaxCapTesti";
            this.chkMaxCapTesti.Size = new System.Drawing.Size(94, 17);
            this.chkMaxCapTesti.TabIndex = 2;
            this.chkMaxCapTesti.Text = "Max Çap Testi";
            this.chkMaxCapTesti.UseVisualStyleBackColor = true;
            // 
            // chkKuvvetTesti
            // 
            this.chkKuvvetTesti.AutoSize = true;
            this.chkKuvvetTesti.Location = new System.Drawing.Point(6, 42);
            this.chkKuvvetTesti.Name = "chkKuvvetTesti";
            this.chkKuvvetTesti.Size = new System.Drawing.Size(86, 17);
            this.chkKuvvetTesti.TabIndex = 1;
            this.chkKuvvetTesti.Text = "Kuvvet Testi";
            this.chkKuvvetTesti.UseVisualStyleBackColor = true;
            // 
            // chkYanalYukTesti
            // 
            this.chkYanalYukTesti.AutoSize = true;
            this.chkYanalYukTesti.Location = new System.Drawing.Point(6, 19);
            this.chkYanalYukTesti.Name = "chkYanalYukTesti";
            this.chkYanalYukTesti.Size = new System.Drawing.Size(101, 17);
            this.chkYanalYukTesti.TabIndex = 0;
            this.chkYanalYukTesti.Text = "Yanal Yük Testi";
            this.chkYanalYukTesti.UseVisualStyleBackColor = true;
            // 
            // btnBitir
            // 
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Image = ((System.Drawing.Image)(resources.GetObject("btnBitir.Image")));
            this.btnBitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitir.Location = new System.Drawing.Point(818, 499);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(140, 60);
            this.btnBitir.TabIndex = 4;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnHepsiniBaslat
            // 
            this.btnHepsiniBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniBaslat.Image = ((System.Drawing.Image)(resources.GetObject("btnHepsiniBaslat.Image")));
            this.btnHepsiniBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHepsiniBaslat.Location = new System.Drawing.Point(818, 433);
            this.btnHepsiniBaslat.Name = "btnHepsiniBaslat";
            this.btnHepsiniBaslat.Size = new System.Drawing.Size(140, 60);
            this.btnHepsiniBaslat.TabIndex = 3;
            this.btnHepsiniBaslat.Text = "BAŞLAT";
            this.btnHepsiniBaslat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHepsiniBaslat.UseVisualStyleBackColor = true;
            this.btnHepsiniBaslat.Click += new System.EventHandler(this.btnHepsiniBaslat_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(774, 509);
            this.zedGraphControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çap Testi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_data_debug);
            this.tabPage3.Controls.Add(this.chk_r);
            this.tabPage3.Controls.Add(this.chk_n);
            this.tabPage3.Controls.Add(this.btnGonder);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.btnTemizle);
            this.tabPage3.Controls.Add(this.txtGelen);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.txtGiden);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.btnBaglan);
            this.tabPage3.Controls.Add(this.cbBaudRate);
            this.tabPage3.Controls.Add(this.cbPort);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Terminal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_data_debug
            // 
            this.chk_data_debug.AutoSize = true;
            this.chk_data_debug.Location = new System.Drawing.Point(632, 434);
            this.chk_data_debug.Name = "chk_data_debug";
            this.chk_data_debug.Size = new System.Drawing.Size(103, 17);
            this.chk_data_debug.TabIndex = 29;
            this.chk_data_debug.Text = "data debug aktif";
            this.chk_data_debug.UseVisualStyleBackColor = true;
            // 
            // chk_r
            // 
            this.chk_r.AutoSize = true;
            this.chk_r.Location = new System.Drawing.Point(540, 101);
            this.chk_r.Name = "chk_r";
            this.chk_r.Size = new System.Drawing.Size(66, 17);
            this.chk_r.TabIndex = 28;
            this.chk_r.Text = "\\r(home)";
            this.chk_r.UseVisualStyleBackColor = true;
            // 
            // chk_n
            // 
            this.chk_n.AutoSize = true;
            this.chk_n.Location = new System.Drawing.Point(473, 101);
            this.chk_n.Name = "chk_n";
            this.chk_n.Size = new System.Drawing.Size(67, 17);
            this.chk_n.TabIndex = 27;
            this.chk_n.Text = "\\n(enter)";
            this.chk_n.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.Image")));
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.Location = new System.Drawing.Point(472, 43);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(127, 53);
            this.btnGonder.TabIndex = 26;
            this.btnGonder.Text = "  GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(628, 164);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 13);
            this.label31.TabIndex = 25;
            this.label31.Text = "Komutlar:\r\n";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(631, 457);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(127, 39);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "  TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtGelen
            // 
            this.txtGelen.Location = new System.Drawing.Point(26, 161);
            this.txtGelen.Multiline = true;
            this.txtGelen.Name = "txtGelen";
            this.txtGelen.ReadOnly = true;
            this.txtGelen.Size = new System.Drawing.Size(573, 335);
            this.txtGelen.TabIndex = 23;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 22;
            this.label30.Text = "Gelen data";
            // 
            // txtGiden
            // 
            this.txtGiden.Location = new System.Drawing.Point(26, 43);
            this.txtGiden.Multiline = true;
            this.txtGiden.Name = "txtGiden";
            this.txtGiden.Size = new System.Drawing.Size(440, 75);
            this.txtGiden.TabIndex = 21;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 20;
            this.label29.Text = "Giden Bilgi";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.Image")));
            this.btnBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaglan.Location = new System.Drawing.Point(631, 96);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(127, 39);
            this.btnBaglan.TabIndex = 19;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(687, 69);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(71, 21);
            this.cbBaudRate.TabIndex = 18;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(687, 42);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(71, 21);
            this.cbPort.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(628, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Baud Rate";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(628, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "COM Port";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 521);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kalibrasyon";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_baglanti
            // 
            this.label_baglanti.AutoSize = true;
            this.label_baglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baglanti.Location = new System.Drawing.Point(875, 9);
            this.label_baglanti.Name = "label_baglanti";
            this.label_baglanti.Size = new System.Drawing.Size(8, 12);
            this.label_baglanti.TabIndex = 9;
            this.label_baglanti.Text = "-";
            // 
            // picDurum
            // 
            this.picDurum.Location = new System.Drawing.Point(940, 9);
            this.picDurum.Name = "picDurum";
            this.picDurum.Size = new System.Drawing.Size(15, 15);
            this.picDurum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDurum.TabIndex = 8;
            this.picDurum.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(786, 521);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hakkında";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "yazan: Remzi ŞAHİNOĞLU\r\ntarih: 01.09.2016\r\nversiyon: 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_baglanti);
            this.Controls.Add(this.btnHidrolikAsagi);
            this.Controls.Add(this.picDurum);
            this.Controls.Add(this.btnHidrolikYukari);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.btnHepsiniBaslat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBuHafta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUretimHaftasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yanal Yük Test Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDurum)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chk_data_debug;
        private System.Windows.Forms.CheckBox chk_r;
        private System.Windows.Forms.CheckBox chk_n;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtGelen;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtGiden;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label_baglanti;
        private System.Windows.Forms.PictureBox picDurum;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnHepsiniBaslat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkMaxCapTesti;
        private System.Windows.Forms.CheckBox chkKuvvetTesti;
        private System.Windows.Forms.CheckBox chkYanalYukTesti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuHafta;
        private System.Windows.Forms.TextBox txtUretimHaftasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRaporOlustur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHidrolikAsagi;
        private System.Windows.Forms.Button btnHidrolikYukari;
        private TabPage tabPage5;
        private Timer timer1;
        private Label label1;
    }
}

