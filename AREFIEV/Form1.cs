using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREFIEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.text = textBox1.Text;
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            if (Program.obr)
            {
                string temp = "";
                char[] arr = Program.text.ToArray();
                for (int i = arr.Length-1; i >=0; i--)
                {
                    temp += arr[i];
                }
                listBox1.Items.Add(temp);
            }
            if (Program.minone)
            {
                string temp = "";
                char[] arr = Program.text.ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i]--;
                }
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    temp += arr[i];
                }
                listBox1.Items.Add(temp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
