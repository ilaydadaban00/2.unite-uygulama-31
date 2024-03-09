using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_31_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAra.Text;
            for(int i=0; i<listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() ==ad)
                {
                    MessageBox.Show(listBox1.Items[i].ToString() + "    musteri bulundu");
                    break;
                }
                

            }
        }
    }
}
