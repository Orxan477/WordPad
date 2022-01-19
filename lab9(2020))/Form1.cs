using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_2020__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Title = "Faylların açılması";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Mətn faylları | *.txt";
            openFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Fayylların yaddaşa verilməsi";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Mətn faylları | *.txt";
            saveFileDialog1.DefaultExt = "txt";
            textBox1.Multiline = true;
            textBox1.AllowDrop = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
        private void FaylaYaz(string faylin_adi)
        {
            StreamWriter sw = new StreamWriter(faylin_adi, false, Encoding.Default);
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string faylin_adi = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(faylin_adi, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string faylin_adi = saveFileDialog1.FileName;
                FaylaYaz(faylin_adi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string faylin_adi = saveFileDialog1.FileName;
            if (faylin_adi == "")
            {
                MessageBox.Show("Fayla ad verin!");
                return;
            }
            else
                FaylaYaz(faylin_adi);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            fontDialog1.MinSize = 8;
            fontDialog1.MaxSize = 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            return;
            else
            {
                this.BackColor = colorDialog1.Color;
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                this.ForeColor = colorDialog2.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string faylin_adi = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(faylin_adi, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string faylin_adi = saveFileDialog1.FileName;
                FaylaYaz(faylin_adi);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string faylin_adi = saveFileDialog1.FileName;
            if (faylin_adi == "")
            {
                MessageBox.Show("Fayla ad verin!");
                return;
            }
            else
                FaylaYaz(faylin_adi);
        }
    }
}
