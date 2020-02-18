using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptocurrencyInquirer
{
    public partial class Form1 : Form
    {
        public List<CryptocurrencyInfo> CryptocurrencyInfoList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {

            if (FormWindowState.Minimized == WindowState)
                Hide();

        }

        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {

            Show();
            WindowState = FormWindowState.Normal;

        }

        void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CryptocurrencyInfoList = new List<CryptocurrencyInfo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ccTickerTbx.Text != string.Empty)
            {
                requestPrice(ccTickerTbx.Text);

                GrpBxCryptocurrencyWatchlist.Visible = true;
                AddCyrptocurrencyInquiryGrpBx.Visible = false;

                CryptocurrencyWatchListLabel.Text = string.Empty;
                foreach (var cci in CryptocurrencyInfoList)
                {
                    CryptocurrencyWatchListLabel.Text += cci.ticker + ": " + Math.Round(cci.price, 2).ToString() + "\n";
                }

            }
        }

        private void requestPrice(string ccTicker)
        {
            string ccTickerFormatted = ccTicker.Trim().ToUpper();
            string url = "https://api.binance.com/api/v1/ticker/price?symbol=" + ccTickerFormatted + "USDT";
            string json = string.Empty;
            int index = 0;

            bool apiCallSuccessful = false;
            try
            {
                using (WebClient wc = new WebClient())
                {

                    json = wc.DownloadString(url);

                }
                apiCallSuccessful = true;

                dynamic binanceJson = JsonConvert.DeserializeObject(json);

                if (!DoesCryptocurrencyInfoListContainTicker(ccTickerFormatted + "USDT", out index))
                {
                    CryptocurrencyInfo cci = new CryptocurrencyInfo();
                    cci.ticker = ccTickerFormatted + "USDT";
                    cci.price = binanceJson.price;
                    CryptocurrencyInfoList.Add(cci);
                }
            }
            catch (Exception ex) {
                Console.Write(ex.ToString());
            }

            if (!apiCallSuccessful)
            {
                url = "https://api.binance.com/api/v1/ticker/price?symbol=" + ccTickerFormatted;
                try
                {
                    using (WebClient wc = new WebClient())
                    {

                        json = wc.DownloadString(url);

                    }
                    apiCallSuccessful = true;

                    dynamic binanceJson = JsonConvert.DeserializeObject(json);

                    if (!DoesCryptocurrencyInfoListContainTicker(ccTickerFormatted, out index))
                    {
                        CryptocurrencyInfo cci = new CryptocurrencyInfo();
                        cci.ticker = ccTickerFormatted;
                        cci.price = binanceJson.price;
                        CryptocurrencyInfoList.Add(cci);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }

            if (json != string.Empty)
            {

            }

        }

        private bool DoesCryptocurrencyInfoListContainTicker(string ticker, out int index)
        {

            index = 0;
            foreach (var cci in CryptocurrencyInfoList)
            {
                if (cci.ticker == ticker)
                {
                    return true;
                }
                index++;
            }

            return false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ccTickerTbx.Focus();
            AddCyrptocurrencyInquiryGrpBx.Visible = true;
            GrpBxCryptocurrencyWatchlist.Visible = false;

        }


        public class CryptocurrencyInfo
        {
            public string ticker;
            public decimal price;
        }


        private void addCryptocurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ccTickerTbx.Focus();
            AddCyrptocurrencyInquiryGrpBx.Visible = true;
            GrpBxCryptocurrencyWatchlist.Visible = false;

        }
    }
}
