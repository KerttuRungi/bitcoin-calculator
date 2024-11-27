using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencyselector.Text.ToString() == "EUR")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                Bitcoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            else if (currencyselector.Text.ToString() == "USD")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                Bitcoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }
            else if (currencyselector.Text.ToString() == "EEK")
            {
                resultlable.Visible = true;
                tulemuslable.Visible = true;
                Bitcoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                //resultlable.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
                result *= (float)(15.6466);
                resultlable.Text = $"{result}Bitcoini";
            }
            else
            {
                MessageBox.Show("Bitcoin valuutat pole valitud. Vali valuuta");
        }
}

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static Bitcoin_rates GetRates ()
            
        { string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
       HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
       request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            Bitcoin_rates bitcoin;
         

            using (var responseReader = new StreamReader(webStream)) 
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<Bitcoin_rates>(data);
        }
            return bitcoin;
    }

        private void resultlable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
