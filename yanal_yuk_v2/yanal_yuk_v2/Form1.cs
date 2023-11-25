using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace yanal_yuk_v2
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();     // port bilgisinin tutulduğu yer
        string Gelen = "";  // serialporttan gelen datanın tutulduğu yer
        string[] istasyon_bilgi = { "0", "0", "0", "0", "0" };   // istasyonlardan gelen bilgilerin ayrıştıtılıp tutulduğu yer

        public double lineer_ruler = 0;    // lineer cetvel datasının tutulduğu değişken

        // yanal yük loadcell datalarının tutulduğu pointlist ler
        PointPairList yanal_loadcell_1 = new PointPairList();
        PointPairList yanal_loadcell_2 = new PointPairList();
        PointPairList yanal_loadcell_3 = new PointPairList();

        PointPairList baski_loadcell = new PointPairList();

        PointPairList lineer_cetvel = new PointPairList();


        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;  // form kapanırken olay yaratmak için atandı
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Terminal için ayarlamalar
            picDurum.ImageLocation = "pasif.png";   // bağlantı durumu için kırmızı renkli gösterge eklendi
            foreach (string port in ports) { cbPort.Items.Add(port); }     // pc ye takılı olan device ların portlarını ekle
            cbBaudRate.Items.Add("300"); cbBaudRate.Items.Add("600"); cbBaudRate.Items.Add("1200"); cbBaudRate.Items.Add("2400");
            cbBaudRate.Items.Add("4800"); cbBaudRate.Items.Add("9600"); cbBaudRate.Items.Add("19200"); cbBaudRate.Items.Add("115200");
            cbBaudRate.SelectedIndex = 6;   // 19200 olarak ayarla
            cbPort.Text = "COM1";   // COM1 olarak ayarla

            // form açıldığında port otomatik açılsın            
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 19200;
            serialPort1.Open();
            btnBaglan.Text = "Bağlantıyı Kes";
            picDurum.ImageLocation = "aktif.png";
            label_baglanti.Text = cbPort.Text + "," + cbBaudRate.Text;

            // grafik ayarlamaları
            GraphPane myPane = zedGraphControl1.GraphPane;  // grafik oluştur
            myPane.Title.Text = "Yanal Yük  ve Kuvvet Eğrileri";
            myPane.XAxis.Title.Text = "Stroke(mm)";
            myPane.YAxis.Title.Text = "Kuvvet(Newton)";

            // curevleri oluşur
            // yanal loadcell ler
            LineItem curve1 = myPane.AddCurve("loadcell-1", yanal_loadcell_1, Color.Red, SymbolType.None);  curve1.Line.Width = 3f;
            LineItem curve2 = myPane.AddCurve("loadcell-2", yanal_loadcell_2, Color.Blue, SymbolType.None);
            LineItem curve3 = myPane.AddCurve("loadcell-3", yanal_loadcell_3, Color.Green, SymbolType.None);

            // baskı loadcelli
            LineItem curve4 = myPane.AddCurve("baskı loadcell", baski_loadcell, Color.Black, SymbolType.None);

            // curve kalınlıklarını belirle
            curve1.Line.Width = 3f;
            curve2.Line.Width = 3f;
            curve3.Line.Width = 3f;
            curve4.Line.Width = 3f;

        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğine emin misin?", "Yanal Yük Test Makinesi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (serialPort1.IsOpen == true) { serialPort1.Close(); }         // port açıksa çıkarken kapat
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;                                                // formu kapatmayı iptal et
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (chk_n.Checked == true && chk_r.Checked == false)
                {
                    serialPort1.Write(txtGiden.Text + "\n");    // giden bilginin sonuna yeni satır(enter) bilgisini koy
                }
                else if (chk_n.Checked == false && chk_r.Checked == true)
                {
                    serialPort1.Write(txtGiden.Text + "\r");    // giden bilginin sonuna satır başı(carriage return) bilgisini koy
                }
                else if (chk_n.Checked == true && chk_r.Checked == true)
                {
                    serialPort1.Write(txtGiden.Text + "\n\r");  // hem yeni satır hem satır başına imleci göndert
                }
                else
                {
                    serialPort1.Write(txtGiden.Text);       // saf olarak gönder
                }
            }
            else
            {
                MessageBox.Show("Port kapalıyken data gönderilemez!");
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBaglan.Text == "Bağlan")     // bağlantıyı kes      
                {
                    btnBaglan.Text = "Bağlantıyı Kes";
                    picDurum.ImageLocation = "aktif.png";
                    label_baglanti.Text = cbPort.Text + "," + cbBaudRate.Text;
                    serialPort1.PortName = cbPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                    serialPort1.Open();     // portu aç
                }
                else                                // bağlan
                {
                    btnBaglan.Text = "Bağlan";
                    picDurum.ImageLocation = "pasif.png";
                    label_baglanti.Text = "-";
                    serialPort1.Close();    // portu kapat
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGelen.Clear();
        }

        private void serialPort1_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            int index = 0;
            string bilgi = "";
            char ch = '0';

            Gelen = serialPort1.ReadLine();                 // gelen bilgiyi oku (direk üzerine yazıyor) readline komutu gelen datanın sonunda enter bilgisi olduğunda çalışıyor
            for (int i = 0; i < Gelen.Length; i++)          // gelen stringinin içindeki bilgileri ayır
            {
                ch = Gelen[i];
                if (ch == ';')
                {
                    // istasyon_bilgi[     0    ,     1     ,      2    ,    3    ,      4      ]
                    // istasyon_bilgi[yanal_lc-1, yanal_lc-2, yanal_lc-3, baskı_lc, lineer_ruler]

                    istasyon_bilgi[index] = bilgi;

                    index++;
                    bilgi = "";
                }
                else
                {
                    bilgi += ch;                                        // birden fazla karakter varsa birleştir
                }
            }

            Gelen = "";                                                 // bufferı temizle
            index = 0;
            ch = '0';

            // test bilgilerini ekrana yaz
            if (chkYanalYukTesti.Checked == true)
            {
                // (x yatay eksen, y dikey eksen)
                yanal_loadcell_1.Add(Convert.ToDouble(istasyon_bilgi[4]), Convert.ToDouble(istasyon_bilgi[0])); // (yatay eksen: lineer cetvel, dikey eksen: yanal loadcell-1)
                yanal_loadcell_2.Add(Convert.ToDouble(istasyon_bilgi[4]), Convert.ToDouble(istasyon_bilgi[1])); // (yatay eksen: lineer cetvel, dikey eksen: yanal loadcell-2)
                yanal_loadcell_3.Add(Convert.ToDouble(istasyon_bilgi[4]), Convert.ToDouble(istasyon_bilgi[2])); // (yatay eksen: lineer cetvel, dikey eksen: yanal loadcell-3)
            }

            if (chkKuvvetTesti.Checked == true)
            {
                baski_loadcell.Add(Convert.ToDouble(istasyon_bilgi[4]), Convert.ToDouble(istasyon_bilgi[3])); // (yatay eksen: lineer cetvel, dikey eksen: baskı loadcell)
            }

            if (chkMaxCapTesti.Checked == true)
            {
                // çap testini zamana göre yada dereceye göre yap
            }           

            // terminal kısmına yazdırmak için
            if (chk_data_debug.Checked == true)                         // checkbox aktif ise gelen data bilgilerini ekrana yaz
            {
                Invoke(new EventHandler(DisplayText));                  // ekrana yazdır
            }
        }

        private void DisplayText(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)                         // 5 adet data geldiği için
            {
                txtGelen.Text += istasyon_bilgi[i] + "   ";     // gelen datayı ekrana yaz
            }
            txtGelen.Text += "\r\n";
        }

        private void btnBuHafta_Click(object sender, EventArgs e)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;                                                                            // kültürü belirle
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);    // haftayı hesapla
            txtUretimHaftasi.Text = Convert.ToString(weekNum);
        }

        private void btnHepsiniBaslat_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("s");                                 // arduino programında analog okuma start komutu
                timer1.Enabled = true;                                  // grafiğin reflesh komutunu aktif et
            }

            if (chkYanalYukTesti.Checked == false && chkKuvvetTesti.Checked == false && chkMaxCapTesti.Checked == false)
            {
                MessageBox.Show("Test Seç!");
            }

        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("r");                                 // arduino programında analog okuma stop komutu
                timer1.Enabled = false;                                 // grafiğin reflesh komutunu pasif et
            }
        }

        private void btnHidrolikYukari_MouseDown(object sender, MouseEventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Write("u");                                 // arduino programında hidrolik yukarı start
            }
        }

        private void btnHidrolikYukari_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("x");                                 // arduino programında hidrolik yukarı stop
            }
        }

        private void btnHidrolikAsagi_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("b");                                 // arduino programında hidrolik aşağı start
            }
        }

        private void btnHidrolikAsagi_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("x");                                 // arduino programında hidrolik aşağı stop
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
}
