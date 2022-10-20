using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zekat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double dolarAltinGr;
            double dolermiktari;
            double ZekatMiktari;
            double TLAltinGr;
            double toplamMalMiktariAltinGr;
            TLAltinGr = Convert.ToDouble(textBox1.Text)/975;
            dolarAltinGr = Convert.ToDouble(textBox2.Text) / 52;
            toplamMalMiktariAltinGr = TLAltinGr + dolarAltinGr;


                MessageBox.Show("zekat miktarı" + toplamMalMiktariAltinGr.ToString());
            
            if (toplamMalMiktariAltinGr >= 80.18)
            {
                ZekatMiktari = (toplamMalMiktariAltinGr / 40) * 975;
                MessageBox.Show("zekat miktarı" + ZekatMiktari.ToString());
            }
            else
            {
                MessageBox.Show("Zekat vermenize gerek yoktur.");
            }

        }
        
        
          
        
    }
}
