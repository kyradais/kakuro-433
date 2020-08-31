using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public static string nama;
        public Form4()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.BackColor = Color.Red;
            }
            else 
            {
                nama = this.textBox1.Text;
                this.Hide();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        public static string getNama()
        {
            return nama;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
           e.Cancel = true;
        }

    }
}
