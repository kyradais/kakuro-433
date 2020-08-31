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
    public partial class Form1 : Form
    {
        public int[,] tab = new int[100,100] ;
        public int[,] lab = new int[100,100] ;
        public int a ;
        public int i ;
        public static bool ver = false;
        public int hour, min, sec, ms = 0;
        public string nama;
        public string level;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Form4 frm4 = new Form4();
            frm4.ShowDialog();


            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //tab[1, 1] = int.Parse(this.textBox1.Text);
            textBox1.MaxLength = 1;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 2] = int.Parse(this.textBox2.Text);
            textBox2.MaxLength = 1;
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 3] = int.Parse(this.textBox3.Text);
            textBox3.MaxLength = 1;
            textBox3.CharacterCasing = CharacterCasing.Lower;
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 4] = int.Parse(this.textBox4.Text);
            textBox4.MaxLength = 1;
            textBox4.CharacterCasing = CharacterCasing.Lower;
            textBox4.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 5] = int.Parse(this.textBox5.Text);
            textBox5.MaxLength = 1;
            textBox5.CharacterCasing = CharacterCasing.Lower;
            textBox5.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 6] = int.Parse(this.textBox6.Text);
            textBox6.MaxLength = 1;
            textBox6.CharacterCasing = CharacterCasing.Lower;
            textBox6.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 7] = int.Parse(this.textBox7.Text);
            textBox7.MaxLength = 1;
            textBox7.CharacterCasing = CharacterCasing.Lower;
            textBox7.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //tab[1, 8] = int.Parse(this.textBox8.Text);
            textBox8.MaxLength = 1;
            textBox8.CharacterCasing = CharacterCasing.Lower;
            textBox8.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 1] = int.Parse(this.textBox16.Text);
            textBox16.MaxLength = 1;
            textBox16.CharacterCasing = CharacterCasing.Lower;
            textBox16.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
           
            //tab[2, 2] = int.Parse(this.textBox15.Text);
            textBox15.MaxLength = 1;
            textBox15.CharacterCasing = CharacterCasing.Lower;
            textBox15.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 3] = int.Parse(this.textBox14.Text);
            textBox14.MaxLength = 1;
            textBox14.CharacterCasing = CharacterCasing.Lower;
            textBox14.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 4] = int.Parse(this.textBox13.Text);
            textBox13.MaxLength = 1;
            textBox13.CharacterCasing = CharacterCasing.Lower;
            textBox13.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 5] = int.Parse(this.textBox12.Text);
            textBox12.MaxLength = 1;
            textBox12.CharacterCasing = CharacterCasing.Lower;
            textBox12.TextAlign = HorizontalAlignment.Center;

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 6] = int.Parse(this.textBox11.Text);
            textBox11.MaxLength = 1;
            textBox11.CharacterCasing = CharacterCasing.Lower;
            textBox11.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 7] = int.Parse(this.textBox10.Text);
            textBox10.MaxLength = 1;
            textBox10.CharacterCasing = CharacterCasing.Lower;
            textBox10.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //tab[2, 8] = int.Parse(this.textBox9.Text);
            textBox9.MaxLength = 1;
            textBox9.CharacterCasing = CharacterCasing.Lower;
            textBox9.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 1] = int.Parse(this.textBox24.Text);
            textBox24.MaxLength = 1;
            textBox24.CharacterCasing = CharacterCasing.Lower;
            textBox24.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 2] = int.Parse(this.textBox23.Text);
            textBox23.MaxLength = 1;
            textBox23.CharacterCasing = CharacterCasing.Lower;
            textBox23.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 3] = int.Parse(this.textBox22.Text);
            textBox22.MaxLength = 1;
            textBox22.CharacterCasing = CharacterCasing.Lower;
            textBox22.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 4] = int.Parse(this.textBox21.Text);
            textBox21.MaxLength = 1;
            textBox21.CharacterCasing = CharacterCasing.Lower;
            textBox21.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 5] = int.Parse(this.textBox20.Text);
            textBox20.MaxLength = 1;
            textBox20.CharacterCasing = CharacterCasing.Lower;
            textBox20.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 6] = int.Parse(this.textBox19.Text);
            textBox19.MaxLength = 1;
            textBox19.CharacterCasing = CharacterCasing.Lower;
            textBox19.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 7] = int.Parse(this.textBox18.Text);
            textBox18.MaxLength = 1;
            textBox18.CharacterCasing = CharacterCasing.Lower;
            textBox18.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //tab[3, 8] = int.Parse(this.textBox17.Text);
            textBox17.MaxLength = 1;
            textBox17.CharacterCasing = CharacterCasing.Lower;
            textBox17.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 1] = int.Parse(this.textBox32.Text);
            textBox32.MaxLength = 1;
            textBox32.CharacterCasing = CharacterCasing.Lower;
            textBox32.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 2] = int.Parse(this.textBox31.Text);
            textBox31.MaxLength = 1;
            textBox31.CharacterCasing = CharacterCasing.Lower;
            textBox31.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 3] = int.Parse(this.textBox30.Text);
            textBox30.MaxLength = 1;
            textBox30.CharacterCasing = CharacterCasing.Lower;
            textBox30.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 4] = int.Parse(this.textBox29.Text);
            textBox29.MaxLength = 1;
            textBox29.CharacterCasing = CharacterCasing.Lower;
            textBox29.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 5] = int.Parse(this.textBox28.Text);
            textBox28.MaxLength = 1;
            textBox28.CharacterCasing = CharacterCasing.Lower;
            textBox28.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 6] = int.Parse(this.textBox27.Text);
            textBox27.MaxLength = 1;
            textBox27.CharacterCasing = CharacterCasing.Lower;
            textBox27.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 7] = int.Parse(this.textBox26.Text);
            textBox26.MaxLength = 1;
            textBox26.CharacterCasing = CharacterCasing.Lower;
            textBox26.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            //tab[4, 8] = int.Parse(this.textBox25.Text);
            textBox25.MaxLength = 1;
            textBox25.CharacterCasing = CharacterCasing.Lower;
            textBox25.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 1] = int.Parse(this.textBox40.Text);
            textBox40.MaxLength = 1;
            textBox40.CharacterCasing = CharacterCasing.Lower;
            textBox40.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 2] = int.Parse(this.textBox39.Text);
            textBox39.MaxLength = 1;
            textBox39.CharacterCasing = CharacterCasing.Lower;
            textBox39.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 3] = int.Parse(this.textBox38.Text);
            textBox38.MaxLength = 1;
            textBox38.CharacterCasing = CharacterCasing.Lower;
            textBox38.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 4] = int.Parse(this.textBox37.Text);
            textBox37.MaxLength = 1;
            textBox37.CharacterCasing = CharacterCasing.Lower;
            textBox37.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 5] = int.Parse(this.textBox36.Text);
            textBox36.MaxLength = 1;
            textBox36.CharacterCasing = CharacterCasing.Lower;
            textBox36.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 6] = int.Parse(this.textBox35.Text);
            textBox35.MaxLength = 1;
            textBox35.CharacterCasing = CharacterCasing.Lower;
            textBox35.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 7] = int.Parse(this.textBox34.Text);
            textBox34.MaxLength = 1;
            textBox34.CharacterCasing = CharacterCasing.Lower;
            textBox34.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            //tab[5, 8] = int.Parse(this.textBox33.Text);
            textBox33.MaxLength = 1;
            textBox33.CharacterCasing = CharacterCasing.Lower;
            textBox33.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 1] = int.Parse(this.textBox48.Text);
            textBox48.MaxLength = 1;
            textBox48.CharacterCasing = CharacterCasing.Lower;
            textBox48.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 2] = int.Parse(this.textBox47.Text);
            textBox47.MaxLength = 1;
            textBox47.CharacterCasing = CharacterCasing.Lower;
            textBox47.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 3] = int.Parse(this.textBox46.Text);
            textBox46.MaxLength = 1;
            textBox46.CharacterCasing = CharacterCasing.Lower;
            textBox46.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 4] = int.Parse(this.textBox45.Text);
            textBox45.MaxLength = 1;
            textBox45.CharacterCasing = CharacterCasing.Lower;
            textBox45.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 5] = int.Parse(this.textBox44.Text);
            textBox44.MaxLength = 1;
            textBox44.CharacterCasing = CharacterCasing.Lower;
            textBox44.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 6] = int.Parse(this.textBox43.Text);
            textBox43.MaxLength = 1;
            textBox43.CharacterCasing = CharacterCasing.Lower;
            textBox43.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 7] = int.Parse(this.textBox42.Text);
            textBox42.MaxLength = 1;
            textBox42.CharacterCasing = CharacterCasing.Lower;
            textBox42.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            //tab[6, 8] = int.Parse(this.textBox41.Text);
            textBox41.MaxLength = 1;
            textBox41.CharacterCasing = CharacterCasing.Lower;
            textBox41.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 1] = int.Parse(this.textBox56.Text);
            textBox56.MaxLength = 1;
            textBox56.CharacterCasing = CharacterCasing.Lower;
            textBox56.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 2] = int.Parse(this.textBox55.Text);
            textBox55.MaxLength = 1;
            textBox55.CharacterCasing = CharacterCasing.Lower;
            textBox55.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 3] = int.Parse(this.textBox54.Text);
            textBox54.MaxLength = 1;
            textBox54.CharacterCasing = CharacterCasing.Lower;
            textBox54.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 4] = int.Parse(this.textBox53.Text);
            textBox53.MaxLength = 1;
            textBox53.CharacterCasing = CharacterCasing.Lower;
            textBox53.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 5] = int.Parse(this.textBox52.Text);
            textBox52.MaxLength = 1;
            textBox52.CharacterCasing = CharacterCasing.Lower;
            textBox52.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 6] = int.Parse(this.textBox51.Text);
            textBox51.MaxLength = 1;
            textBox51.CharacterCasing = CharacterCasing.Lower;
            textBox51.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 7] = int.Parse(this.textBox50.Text);
            textBox50.MaxLength = 1;
            textBox50.CharacterCasing = CharacterCasing.Lower;
            textBox50.TextAlign = HorizontalAlignment.Center;

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            //tab[7, 8] = int.Parse(this.textBox49.Text);
            textBox49.MaxLength = 1;
            textBox49.CharacterCasing = CharacterCasing.Lower;
            textBox49.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 1] = int.Parse(this.textBox64.Text);
            textBox64.MaxLength = 1;
            textBox64.CharacterCasing = CharacterCasing.Lower;
            textBox64.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 2] = int.Parse(this.textBox63.Text);
            textBox63.MaxLength = 1;
            textBox63.CharacterCasing = CharacterCasing.Lower;
            textBox63.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 3] = int.Parse(this.textBox62.Text);
            textBox62.MaxLength = 1;
            textBox62.CharacterCasing = CharacterCasing.Lower;
            textBox62.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 4] = int.Parse(this.textBox61.Text);
            textBox61.MaxLength = 1;
            textBox61.CharacterCasing = CharacterCasing.Lower;
            textBox61.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 5] = int.Parse(this.textBox60.Text);
            textBox60.MaxLength = 1;
            textBox60.CharacterCasing = CharacterCasing.Lower;
            textBox60.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 6] = int.Parse(this.textBox59.Text);
            textBox59.MaxLength = 1;
            textBox59.CharacterCasing = CharacterCasing.Lower;
            textBox59.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 7] = int.Parse(this.textBox58.Text);
            textBox58.MaxLength = 1;
            textBox58.CharacterCasing = CharacterCasing.Lower;
            textBox58.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //tab[8, 8] = int.Parse(this.textBox57.Text);
            textBox57.MaxLength = 1;
            textBox57.CharacterCasing = CharacterCasing.Lower;
            textBox57.TextAlign = HorizontalAlignment.Center;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clear();

            //timer
            
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            this.textBox67.Text = "";
            this.textBox66.Text = "";
            this.textBox65.Text = "";
            timer1.Start();

            //level
            if (this.comboBox1.Text == "Level 1")
            {
                tab = RandomKey.random();
            }
            else if (this.comboBox1.Text == "Level 2")
            {
                tab = RandomKey2.random();
            }
            else if (this.comboBox1.Text == "Level 3")
            {
                tab = RandomKey3.random();
            }
            else if (this.comboBox1.Text == "Level 4")
            {
                tab = RandomKey4.random();
            }
            else if (this.comboBox1.Text == "Level 5")
            {
                tab = RandomKey5.random();
            }
            else if (this.comboBox1.Text == "Level 6")
            {
                tab = RandomKey6.random();
            }
            else if (this.comboBox1.Text == "Level 7")
            {
                tab = RandomKey7.random();
            }
            else if (this.comboBox1.Text == "Level 8")
            {
                tab = RandomKey8.random();
            }
            else
            {
                tab = RandomKey.random();
            }


            tab[2, 2] = 0;
            tab[2, 3] = 0;
            tab[2, 4] = 0;

            tab[2, 6] = 0;
            tab[2, 7] = 0;
            tab[2, 8] = 0;

            tab[3, 2] = 0;
            tab[3, 3] = 0;
            tab[3, 4] = 0;

            tab[3, 6] = 0;
            tab[3, 7] = 0;
            tab[3, 8] = 0;

            tab[4, 2] = 0;
            tab[4, 3] = 0;
            tab[4, 4] = 0;

            tab[4, 6] = 0;
            tab[4, 7] = 0;
            tab[4, 8] = 0;

            tab[6, 2] = 0;
            tab[6, 3] = 0;
            tab[6, 4] = 0;

            tab[6, 6] = 0;
            tab[6, 7] = 0;
            tab[6, 8] = 0;

            tab[7, 2] = 0;
            tab[7, 3] = 0;
            tab[7, 4] = 0;

            tab[7, 6] = 0;
            tab[7, 7] = 0;
            tab[7, 8] = 0;

            tab[8, 2] = 0;
            tab[8, 3] = 0;
            tab[8, 4] = 0;

            tab[8, 6] = 0;
            tab[8, 7] = 0;
            tab[8, 8] = 0;

            //this.textBox1.Text = Convert.ToString(tab[1,1]);
            this.textBox2.Text = Convert.ToString(tab[1,2]);
            this.textBox3.Text = Convert.ToString(tab[1,3]);
            this.textBox4.Text = Convert.ToString(tab[1,4]);
            //this.textBox5.Text = Convert.ToString(tab[1,5]);
            this.textBox6.Text = Convert.ToString(tab[1,6]);
            this.textBox7.Text = Convert.ToString(tab[1,7]);
            this.textBox8.Text = Convert.ToString(tab[1,8]);
            
            this.textBox16.Text = Convert.ToString(tab[2,1]);
            this.textBox24.Text = Convert.ToString(tab[3,1]);
            this.textBox32.Text = Convert.ToString(tab[4,1]);

            this.textBox12.Text = Convert.ToString(tab[2,5]);
            this.textBox20.Text = Convert.ToString(tab[3,5]);
            this.textBox28.Text = Convert.ToString(tab[4,5]);

            //this.textBox40.Text = Convert.ToString(tab[5,1]);
            this.textBox39.Text = Convert.ToString(tab[5,2]);
            this.textBox38.Text = Convert.ToString(tab[5,3]);
            this.textBox37.Text = Convert.ToString(tab[5,4]);
            //this.textBox36.Text = Convert.ToString(tab[5,5]);
            this.textBox35.Text = Convert.ToString(tab[5,6]);
            this.textBox34.Text = Convert.ToString(tab[5,7]);
            this.textBox33.Text = Convert.ToString(tab[5,8]);

            this.textBox48.Text = Convert.ToString(tab[6,1]);
            this.textBox56.Text = Convert.ToString(tab[7,1]);
            this.textBox64.Text = Convert.ToString(tab[8,1]);

            this.textBox44.Text = Convert.ToString(tab[6,5]);
            this.textBox52.Text = Convert.ToString(tab[7,5]);
            this.textBox60.Text = Convert.ToString(tab[8,5]);

 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a = 0 ;


            this.textBox15.BackColor = Color.White;
            this.textBox14.BackColor = Color.White;
            this.textBox13.BackColor = Color.White;

            this.textBox11.BackColor = Color.White;
            this.textBox10.BackColor = Color.White;
            this.textBox9.BackColor = Color.White;

            this.textBox23.BackColor = Color.White;
            this.textBox22.BackColor = Color.White;
            this.textBox21.BackColor = Color.White;

            this.textBox19.BackColor = Color.White;
            this.textBox18.BackColor = Color.White;
            this.textBox17.BackColor = Color.White;

            this.textBox31.BackColor = Color.White;
            this.textBox30.BackColor = Color.White;
            this.textBox29.BackColor = Color.White;

            this.textBox27.BackColor = Color.White;
            this.textBox26.BackColor = Color.White;
            this.textBox25.BackColor = Color.White;

            this.textBox47.BackColor = Color.White;
            this.textBox46.BackColor = Color.White;
            this.textBox45.BackColor = Color.White;

            this.textBox43.BackColor = Color.White;
            this.textBox42.BackColor = Color.White;
            this.textBox41.BackColor = Color.White;

            this.textBox55.BackColor = Color.White;
            this.textBox54.BackColor = Color.White;
            this.textBox53.BackColor = Color.White;

            this.textBox51.BackColor = Color.White;
            this.textBox50.BackColor = Color.White;
            this.textBox49.BackColor = Color.White;

            this.textBox63.BackColor = Color.White;
            this.textBox62.BackColor = Color.White;
            this.textBox61.BackColor = Color.White;

            this.textBox59.BackColor = Color.White;
            this.textBox58.BackColor = Color.White;
            this.textBox57.BackColor = Color.White;

            lab[1, 1] = 0;
            lab[1, 2] = 0;
            lab[1, 3] = 0;
            lab[1, 4] = 0;
            lab[1, 5] = 0;
            lab[1, 6] = 0;
            lab[1, 7] = 0;
            lab[1, 8] = 0;
            lab[2, 1] = 0;
            lab[2, 5] = 0;
            lab[3, 1] = 0;
            lab[3, 5] = 0;
            lab[4, 1] = 0;
            lab[4, 5] = 0;
            lab[5, 1] = 0;
            lab[5, 2] = 0;
            lab[5, 3] = 0;
            lab[5, 4] = 0;
            lab[5, 5] = 0;
            lab[5, 6] = 0;
            lab[5, 7] = 0;
            lab[5, 8] = 0;
            lab[6, 1] = 0;
            lab[6, 5] = 0;
            lab[7, 1] = 0;
            lab[7, 5] = 0;
            lab[8, 1] = 0;
            lab[8, 5] = 0;

            //inisialisasi        
            if (this.textBox15.Text == "")
            {
                //this.textBox15.BackColor = Color.Red;
                tab[2, 2] = 0;
            }
            else
            {
                tab[2, 2] = int.Parse(this.textBox15.Text);
            }

            if (this.textBox14.Text == "")
            {
                //this.textBox14.BackColor = Color.Red;
                tab[2, 3] = 0;
            }
            else
            {
                tab[2, 3] = int.Parse(this.textBox14.Text);
            }

            if (this.textBox13.Text == "")
            {
                //this.textBox13.BackColor = Color.Red;
                tab[2, 4] = 0;
            }
            else
            {
                tab[2, 4] = int.Parse(this.textBox13.Text);
            }

            if (this.textBox11.Text == "")
            {
                //this.textBox11.BackColor = Color.Red;
                tab[2, 6] = 0;
            }
            else
            {
                tab[2, 6] = int.Parse(this.textBox11.Text);
            }

            if (this.textBox10.Text == "")
            {
                //this.textBox10.BackColor = Color.Red;
                tab[2, 7] = 0;
            }
            else
            {
                tab[2, 7] = int.Parse(this.textBox10.Text);
            }

            if (this.textBox9.Text == "")
            {
                //this.textBox9.BackColor = Color.Red;
                tab[2, 8] = 0;
            }
            else
            {
                tab[2, 8] = int.Parse(this.textBox9.Text);
            }

            if (this.textBox23.Text == "")
            {
                //this.textBox23.BackColor = Color.Red;
                tab[3, 2] = 0;
            }
            else
            {
                tab[3, 2] = int.Parse(this.textBox23.Text);
            }

            if (this.textBox22.Text == "")
            {
                //this.textBox22.BackColor = Color.Red;
                tab[3, 3] = 0;
            }
            else
            {
                tab[3, 3] = int.Parse(this.textBox22.Text);
            }

            if (this.textBox21.Text == "")
            {
                //this.textBox21.BackColor = Color.Red;
                tab[3, 4] = 0;
            }
            else
            {
                tab[3, 4] = int.Parse(this.textBox21.Text);
            }

            if (this.textBox19.Text == "")
            {
                //this.textBox19.BackColor = Color.Red;
                tab[3, 6] = 0;
            }
            else
            {
                tab[3, 6] = int.Parse(this.textBox19.Text);
            }

            if (this.textBox18.Text == "")
            {
                // this.textBox18.BackColor = Color.Red;
                tab[3, 7] = 0;
            }
            else
            {
                tab[3, 7] = int.Parse(this.textBox18.Text);
            }

            if (this.textBox17.Text == "")
            {
                // this.textBox17.BackColor = Color.Red;
                tab[3, 8] = 0;
            }
            else
            {
                tab[3, 8] = int.Parse(this.textBox17.Text);
            }

            if (this.textBox31.Text == "")
            {
                //this.textBox31.BackColor = Color.Red;
                tab[4, 2] = 0;
            }
            else
            {
                tab[4, 2] = int.Parse(this.textBox31.Text);
            }

            if (this.textBox30.Text == "")
            {
                // this.textBox30.BackColor = Color.Red;
                tab[4, 3] = 0;
            }
            else
            {
                tab[4, 3] = int.Parse(this.textBox30.Text);
            }

            if (this.textBox29.Text == "")
            {
                //this.textBox29.BackColor = Color.Red;
                tab[4, 4] = 0;
            }
            else
            {
                tab[4, 4] = int.Parse(this.textBox29.Text);
            }

            if (this.textBox27.Text == "")
            {
                // this.textBox27.BackColor = Color.Red;
                tab[4, 6] = 0;
            }
            else
            {
                tab[4, 6] = int.Parse(this.textBox27.Text);
            }

            if (this.textBox26.Text == "")
            {
                //this.textBox26.BackColor = Color.Red;
                tab[4, 7] = 0;
            }
            else
            {
                tab[4, 7] = int.Parse(this.textBox26.Text);
            }

            if (this.textBox25.Text == "")
            {
                // this.textBox25.BackColor = Color.Red;
                tab[4, 8] = 0;
            }
            else
            {
                tab[4, 8] = int.Parse(this.textBox25.Text);
            }

            if (this.textBox47.Text == "")
            {
                // this.textBox47.BackColor = Color.Red;
                tab[6, 2] = 0;
            }
            else
            {
                tab[6, 2] = int.Parse(this.textBox47.Text);
            }

            if (this.textBox46.Text == "")
            {
                // this.textBox46.BackColor = Color.Red;
                tab[6, 3] = 0;
            }
            else
            {
                tab[6, 3] = int.Parse(this.textBox46.Text);
            }

            if (this.textBox45.Text == "")
            {
                // this.textBox45.BackColor = Color.Red;
                tab[6, 4] = 0;
            }
            else
            {
                tab[6, 4] = int.Parse(this.textBox45.Text);
            }

            if (this.textBox43.Text == "")
            {
                // this.textBox43.BackColor = Color.Red;
                tab[6, 6] = 0;
            }
            else
            {
                tab[6, 6] = int.Parse(this.textBox43.Text);
            }

            if (this.textBox42.Text == "")
            {
                // this.textBox42.BackColor = Color.Red;
                tab[6, 7] = 0;
            }
            else
            {
                tab[6, 7] = int.Parse(this.textBox42.Text);
            }

            if (this.textBox41.Text == "")
            {
                // this.textBox41.BackColor = Color.Red;
                tab[6, 8] = 0;
            }
            else
            {
                tab[6, 8] = int.Parse(this.textBox41.Text);
            }

            if (this.textBox55.Text == "")
            {
                // this.textBox55.BackColor = Color.Red;
                tab[7, 2] = 0;
            }
            else
            {
                tab[7, 2] = int.Parse(this.textBox55.Text);
            }

            if (this.textBox54.Text == "")
            {
                // this.textBox54.BackColor = Color.Red;
                tab[7, 3] = 0;
            }
            else
            {
                tab[7, 3] = int.Parse(this.textBox54.Text);
            }

            if (this.textBox53.Text == "")
            {
                // this.textBox53.BackColor = Color.Red;
                tab[7, 4] = 0;
            }
            else
            {
                tab[7, 4] = int.Parse(this.textBox53.Text);
            }

            if (this.textBox51.Text == "")
            {
                // this.textBox51.BackColor = Color.Red;
                tab[7, 6] = 0;
            }
            else
            {
                tab[7, 6] = int.Parse(this.textBox51.Text);
            }

            if (this.textBox50.Text == "")
            {
                // this.textBox50.BackColor = Color.Red;
                tab[7, 7] = 0;
            }
            else
            {
                tab[7, 7] = int.Parse(this.textBox50.Text);
            }

            if (this.textBox49.Text == "")
            {
                // this.textBox49.BackColor = Color.Red;
                tab[7, 8] = 0;
            }
            else
            {
                tab[7, 8] = int.Parse(this.textBox49.Text);
            }

            if (this.textBox63.Text == "")
            {
                //  this.textBox63.BackColor = Color.Red;
                tab[8, 2] = 0;
            }
            else
            {
                tab[8, 2] = int.Parse(this.textBox63.Text);
            }

            if (this.textBox62.Text == "")
            {
                // this.textBox62.BackColor = Color.Red;
                tab[8, 3] = 0;
            }
            else
            {
                tab[8, 3] = int.Parse(this.textBox62.Text);
            }

            if (this.textBox61.Text == "")
            {
                //  this.textBox61.BackColor = Color.Red;
                tab[8, 4] = 0;
            }
            else
            {
                tab[8, 4] = int.Parse(this.textBox61.Text);
            }

            if (this.textBox59.Text == "")
            {
                //  this.textBox59.BackColor = Color.Red;
                tab[8, 6] = 0;
            }
            else
            {
                tab[8, 6] = int.Parse(this.textBox59.Text);
            }

            if (this.textBox58.Text == "")
            {
                // this.textBox58.BackColor = Color.Red;
                tab[8, 7] = 0;
            }
            else
            {
                tab[8, 7] = int.Parse(this.textBox58.Text);
            }

            if (this.textBox57.Text == "")
            {
                // this.textBox57.BackColor = Color.Red;
                tab[8, 8] = 0;
            }
            else
            {
                tab[8, 8] = int.Parse(this.textBox57.Text);
            }

           

            //penjumlahan kolom atas
            for (i = 2; i < 5; i++)
            {
                lab[1, 2] = lab[1, 2] + tab[i, 2];
                
                lab[1, 3] = lab[1, 3] + tab[i, 3];
                
                lab[1, 4] = lab[1, 4] + tab[i, 4];
                

                lab[1, 6] = lab[1, 6] + tab[i, 6];
                
                lab[1, 7] = lab[1, 7] + tab[i, 7];
                
                lab[1, 8] = lab[1, 8] + tab[i, 8];
                
            }

            //penjumlahan baris kiri
            for (i = 2; i < 5; i++)
            {
                lab[2, 1] = lab[2, 1] + tab[2, i];
                
                lab[3, 1] = lab[3, 1] + tab[3, i];
               
                lab[4, 1] = lab[4, 1] + tab[4, i];
                

                lab[6, 1] = lab[6, 1] + tab[6, i];
                
                lab[7, 1] = lab[7, 1] + tab[7, i];
                
                lab[8, 1] = lab[8, 1] + tab[8, i];
                
            }

            //penjumlahan kolom bawah
            for (i = 6; i < 9; i++)
            {
                lab[5, 2] = lab[5, 2] + tab[i, 2];
                
                lab[5, 3] = lab[5, 3] + tab[i, 3];
               
                lab[5, 4] = lab[5, 4] + tab[i, 4];
                

                lab[5, 6] = lab[5, 6] + tab[i, 6];
                
                lab[5, 7] = lab[5, 7] + tab[i, 7];
                
                lab[5, 8] = lab[5, 8] + tab[i, 8];
                
            }

            //penjumlahan baris kanan
            for (i = 6; i < 9; i++)
            {
                lab[2, 5] = lab[2, 5] + tab[2, i];
                
                lab[3, 5] = lab[3, 5] + tab[3, i];
                
                lab[4, 5] = lab[4, 5] + tab[4, i];
                

                lab[6, 5] = lab[6, 5] + tab[6, i];
                
                lab[7, 5] = lab[7, 5] + tab[7, i];
               
                lab[8, 5] = lab[8, 5] + tab[8, i];
                
            }

            //Warna
            if (lab[1, 2] == tab[1, 2])
            {
            }
            else
            {
                this.textBox15.BackColor = Color.Red;
                this.textBox23.BackColor = Color.Red;
                this.textBox31.BackColor = Color.Red;
            }
            if (lab[1, 3] == tab[1, 3])
            {
            }
            else
            {
                this.textBox14.BackColor = Color.Red;
                this.textBox22.BackColor = Color.Red;
                this.textBox30.BackColor = Color.Red;
            }
            if (lab[1, 4] == tab[1, 4])
            {
            }
            else
            {
                this.textBox13.BackColor = Color.Red;
                this.textBox21.BackColor = Color.Red;
                this.textBox29.BackColor = Color.Red;
            }
            if (lab[1, 6] == tab[1, 6])
            {
            }
            else
            {
                this.textBox11.BackColor = Color.Red;
                this.textBox19.BackColor = Color.Red;
                this.textBox27.BackColor = Color.Red;
            }
            if (lab[1, 7] == tab[1, 7])
            {
            }
            else
            {
                this.textBox10.BackColor = Color.Red;
                this.textBox18.BackColor = Color.Red;
                this.textBox26.BackColor = Color.Red;
            }
            if (lab[1, 8] == tab[1, 8])
            {
            }
            else
            {
                this.textBox9.BackColor = Color.Red;
                this.textBox17.BackColor = Color.Red;
                this.textBox25.BackColor = Color.Red;
            }
            if (lab[2, 1] == tab[2, 1])
            {
            }
            else
            {
                this.textBox15.BackColor = Color.Red;
                this.textBox14.BackColor = Color.Red;
                this.textBox13.BackColor = Color.Red;
            }
            if (lab[3, 1] == tab[3, 1])
            {
            }
            else
            {
                this.textBox23.BackColor = Color.Red;
                this.textBox22.BackColor = Color.Red;
                this.textBox21.BackColor = Color.Red;
            }
            if (lab[4, 1] == tab[4, 1])
            {
            }
            else
            {
                this.textBox31.BackColor = Color.Red;
                this.textBox30.BackColor = Color.Red;
                this.textBox29.BackColor = Color.Red;
            }
            if (lab[6, 1] == tab[6, 1])
            {
            }
            else
            {
                this.textBox47.BackColor = Color.Red;
                this.textBox46.BackColor = Color.Red;
                this.textBox45.BackColor = Color.Red;
            }
            if (lab[7, 1] == tab[7, 1])
            {
            }
            else
            {
                this.textBox55.BackColor = Color.Red;
                this.textBox54.BackColor = Color.Red;
                this.textBox53.BackColor = Color.Red;
            }
            if (lab[8, 1] == tab[8, 1])
            {
            }
            else
            {
                this.textBox63.BackColor = Color.Red;
                this.textBox62.BackColor = Color.Red;
                this.textBox61.BackColor = Color.Red;
            }
            if (lab[5, 2] == tab[5, 2])
            {
            }
            else
            {
                this.textBox47.BackColor = Color.Red;
                this.textBox55.BackColor = Color.Red;
                this.textBox63.BackColor = Color.Red;
            }
            if (lab[5, 3] == tab[5, 3])
            {
            }
            else
            {
                this.textBox46.BackColor = Color.Red;
                this.textBox54.BackColor = Color.Red;
                this.textBox62.BackColor = Color.Red;
            }
            if (lab[5, 4] == tab[5, 4])
            {
            }
            else
            {
                this.textBox45.BackColor = Color.Red;
                this.textBox53.BackColor = Color.Red;
                this.textBox61.BackColor = Color.Red;
            }
            if (lab[5, 6] == tab[5, 6])
            {
            }
            else
            {
                this.textBox43.BackColor = Color.Red;
                this.textBox51.BackColor = Color.Red;
                this.textBox59.BackColor = Color.Red;
            }
            if (lab[5, 7] == tab[5, 7])
            {
            }
            else
            {
                this.textBox42.BackColor = Color.Red;
                this.textBox50.BackColor = Color.Red;
                this.textBox58.BackColor = Color.Red;
            }
            if (lab[5, 8] == tab[5, 8])
            {
            }
            else
            {
                this.textBox41.BackColor = Color.Red;
                this.textBox49.BackColor = Color.Red;
                this.textBox57.BackColor = Color.Red;
            }
            if (lab[2, 5] == tab[2, 5])
            {
            }
            else
            {
                this.textBox11.BackColor = Color.Red;
                this.textBox10.BackColor = Color.Red;
                this.textBox9.BackColor = Color.Red;
            }
            if (lab[3, 5] == tab[3, 5])
            {
            }
            else
            {
                this.textBox19.BackColor = Color.Red;
                this.textBox18.BackColor = Color.Red;
                this.textBox17.BackColor = Color.Red;
            }
            if (lab[4, 5] == tab[4, 5])
            {
            }
            else
            {
                this.textBox27.BackColor = Color.Red;
                this.textBox26.BackColor = Color.Red;
                this.textBox25.BackColor = Color.Red;
            }
            if (lab[6, 5] == tab[6, 5])
            {
            }
            else
            {
                this.textBox43.BackColor = Color.Red;
                this.textBox42.BackColor = Color.Red;
                this.textBox41.BackColor = Color.Red;
            }
            if (lab[7, 5] == tab[7, 5])
            {
            }
            else
            {
                this.textBox51.BackColor = Color.Red;
                this.textBox50.BackColor = Color.Red;
                this.textBox49.BackColor = Color.Red;
            }
            if (lab[8, 5] == tab[8, 5])
            {
            }
            else
            {
                this.textBox59.BackColor = Color.Red;
                this.textBox58.BackColor = Color.Red;
                this.textBox57.BackColor = Color.Red;
            }

            
            for (i = 2; i < 5; i++)
            {
                if (lab[1, i] == tab[1, i])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[i, 1] == tab[i, 1])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[5, i] == tab[5, i])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[i, 5] == tab[i, 5])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }
            }

            for (i = 6; i < 9; i++)
            {
                if (lab[1, i] == tab[1, i])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[i, 1] == tab[i, 1])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[5, i] == tab[5, i])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }

                if (lab[i, 5] == tab[i, 5])
                {
                    //-/a = 0 ;
                }
                else
                {
                    a = a + 1 ;
                }
            }

            change();
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            textBox68.TextAlign = HorizontalAlignment.Center;
        }

        public void change() 
        {
            this.textBox68.Text = "null";
            if (a > 0)
            {
                this.textBox68.BackColor = Color.Red;
                this.textBox68.Text = Convert.ToString("Ada yang Salah");
            }
            else 
            {
                timer1.Stop();
                this.textBox68.BackColor = Color.Green;
                this.textBox69.Text = hour + " : " +min+ " : "+sec.ToString();
                this.textBox68.Text = Convert.ToString("BENAR !!");
                nama = Form4.getNama();
                level = this.comboBox1.Text;
                MessageBox.Show("Selamat " + nama + ", Anda MENANG !!!\nWaktu Anda " + this.textBox69.Text + " Pada " + this.comboBox1.Text);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear() 
        {
            //time clear
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            this.textBox67.Text = "";
            this.textBox66.Text = "";
            this.textBox65.Text = "";
            this.textBox69.Text = "";
            this.textBox68.BackColor = Color.DarkGray;
            timer1.Stop();
            //=-----------------
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox16.Text = "";
            this.textBox15.Text = "";
            this.textBox14.Text = "";
            this.textBox13.Text = "";
            this.textBox12.Text = "";
            this.textBox11.Text = "";
            this.textBox10.Text = "";
            this.textBox9.Text = "";
            this.textBox24.Text = "";
            this.textBox23.Text = "";
            this.textBox22.Text = "";
            this.textBox21.Text = "";
            this.textBox20.Text = "";
            this.textBox19.Text = "";
            this.textBox18.Text = "";
            this.textBox17.Text = "";
            this.textBox32.Text = "";
            this.textBox31.Text = "";
            this.textBox30.Text = "";
            this.textBox29.Text = "";
            this.textBox28.Text = "";
            this.textBox27.Text = "";
            this.textBox26.Text = "";
            this.textBox25.Text = "";
            this.textBox40.Text = "";
            this.textBox39.Text = "";
            this.textBox38.Text = "";
            this.textBox37.Text = "";
            this.textBox36.Text = "";
            this.textBox35.Text = "";
            this.textBox34.Text = "";
            this.textBox33.Text = "";
            this.textBox48.Text = "";
            this.textBox47.Text = "";
            this.textBox46.Text = "";
            this.textBox45.Text = "";
            this.textBox44.Text = "";
            this.textBox43.Text = "";
            this.textBox42.Text = "";
            this.textBox41.Text = "";
            this.textBox56.Text = "";
            this.textBox55.Text = "";
            this.textBox54.Text = "";
            this.textBox53.Text = "";
            this.textBox52.Text = "";
            this.textBox51.Text = "";
            this.textBox50.Text = "";
            this.textBox49.Text = "";
            this.textBox64.Text = "";
            this.textBox63.Text = "";
            this.textBox62.Text = "";
            this.textBox61.Text = "";
            this.textBox60.Text = "";
            this.textBox59.Text = "";
            this.textBox58.Text = "";
            this.textBox57.Text = "";
            this.textBox68.Text = "";

            this.textBox15.BackColor = Color.White;
            this.textBox14.BackColor = Color.White;
            this.textBox13.BackColor = Color.White;

            this.textBox11.BackColor = Color.White;
            this.textBox10.BackColor = Color.White;
            this.textBox9.BackColor = Color.White;

            this.textBox23.BackColor = Color.White;
            this.textBox22.BackColor = Color.White;
            this.textBox21.BackColor = Color.White;

            this.textBox19.BackColor = Color.White;
            this.textBox18.BackColor = Color.White;
            this.textBox17.BackColor = Color.White;

            this.textBox31.BackColor = Color.White;
            this.textBox30.BackColor = Color.White;
            this.textBox29.BackColor = Color.White;

            this.textBox27.BackColor = Color.White;
            this.textBox26.BackColor = Color.White;
            this.textBox25.BackColor = Color.White;

            this.textBox47.BackColor = Color.White;
            this.textBox46.BackColor = Color.White;
            this.textBox45.BackColor = Color.White;

            this.textBox43.BackColor = Color.White;
            this.textBox42.BackColor = Color.White;
            this.textBox41.BackColor = Color.White;

            this.textBox55.BackColor = Color.White;
            this.textBox54.BackColor = Color.White;
            this.textBox53.BackColor = Color.White;

            this.textBox51.BackColor = Color.White;
            this.textBox50.BackColor = Color.White;
            this.textBox49.BackColor = Color.White;

            this.textBox63.BackColor = Color.White;
            this.textBox62.BackColor = Color.White;
            this.textBox61.BackColor = Color.White;

            this.textBox59.BackColor = Color.White;
            this.textBox58.BackColor = Color.White;
            this.textBox57.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox67.Text = sec.ToString();
            this.textBox66.Text = min.ToString();
            this.textBox65.Text = hour.ToString();

            ms++;
            if (ms > 15)
            {
                sec++;
                ms = 0;
            }
            else 
            {
                ms++;
            }
            if (sec > 59)
            {
                min++;
                sec = 0;
            }
            if (min > 59) 
            {
                hour++;
                min = 0;
            }
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            textBox69.TextAlign = HorizontalAlignment.Center;

        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textBox15.SelectAll();
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.SelectAll();
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.SelectAll();
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.SelectAll();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.SelectAll();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.SelectAll();
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            textBox17.SelectAll();
        }

        private void textBox18_Click(object sender, EventArgs e)
        {
            textBox18.SelectAll();
        }

        private void textBox19_Click(object sender, EventArgs e)
        {
            textBox19.SelectAll();
        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            textBox21.SelectAll();
        }

        private void textBox22_Click(object sender, EventArgs e)
        {
            textBox22.SelectAll();
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            textBox23.SelectAll();
        }

        private void textBox25_Click(object sender, EventArgs e)
        {
            textBox25.SelectAll();
        }

        private void textBox26_Click(object sender, EventArgs e)
        {
            textBox26.SelectAll();
        }

        private void textBox27_Click(object sender, EventArgs e)
        {
            textBox27.SelectAll();
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            textBox29.SelectAll();
        }

        private void textBox30_Click(object sender, EventArgs e)
        {
            textBox30.SelectAll();
        }

        private void textBox31_Click(object sender, EventArgs e)
        {
            textBox31.SelectAll();
        }

        private void textBox41_Click(object sender, EventArgs e)
        {
            textBox41.SelectAll();
        }

        private void textBox42_Click(object sender, EventArgs e)
        {
            textBox42.SelectAll();
        }

        private void textBox43_Click(object sender, EventArgs e)
        {
            textBox43.SelectAll();
        }

        private void textBox45_Click(object sender, EventArgs e)
        {
            textBox45.SelectAll();
        }

        private void textBox46_Click(object sender, EventArgs e)
        {
            textBox46.SelectAll();
        }

        private void textBox47_Click(object sender, EventArgs e)
        {
            textBox47.SelectAll();
        }

        private void textBox49_Click(object sender, EventArgs e)
        {
            textBox49.SelectAll();
        }

        private void textBox50_Click(object sender, EventArgs e)
        {
            textBox50.SelectAll();
        }

        private void textBox51_Click(object sender, EventArgs e)
        {
            textBox51.SelectAll();
        }

        private void textBox53_Click(object sender, EventArgs e)
        {
            textBox53.SelectAll();
        }

        private void textBox54_Click(object sender, EventArgs e)
        {
            textBox54.SelectAll();
        }

        private void textBox55_Click(object sender, EventArgs e)
        {
            textBox55.SelectAll();
        }

        private void textBox57_Click(object sender, EventArgs e)
        {
            textBox57.SelectAll();
        }

        private void textBox58_Click(object sender, EventArgs e)
        {
            textBox58.SelectAll();
        }

        private void textBox59_Click(object sender, EventArgs e)
        {
            textBox59.SelectAll();
        }

        private void textBox61_Click(object sender, EventArgs e)
        {
            textBox61.SelectAll();
        }

        private void textBox62_Click(object sender, EventArgs e)
        {
            textBox62.SelectAll();
        }

        private void textBox63_Click(object sender, EventArgs e)
        {
            textBox63.SelectAll();
        }

      



    }
}
