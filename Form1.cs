using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVG_MK_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SolveKVG(int n1, int n2)
        {
            bool erUit = false;
            int uit = 0;
            List<int> nummers1 = new List<int>() { n1 };
            List<int> nummers2 = new List<int>() { n2 };
            int index = 1;
            while (!erUit)
            {
                nummers1.Add(n1 * index);
                nummers2.Add(n2 * index);
                index++;
                foreach (var nummer01 in nummers1)
                {
                    foreach (var nummer02 in nummers2)
                    {
                        if (nummer01 == nummer02)
                        {
                            erUit = true;
                            uit = nummer01;
                        }
                        
                    }
                }
            }
            return uit;
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            try
            {
                lblOut.Text = "Het kleinst gemene veelvoud van " + int.Parse(textBox1.Text).ToString() + " en " + int.Parse(textBox2.Text).ToString() + " is " + SolveKVG(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Type");
            }
             
        }

    }
  }

