using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_NX_Launch
{
    public partial class Credentials : Form
    {
        public string Un
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Pw
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public Credentials()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if values are filled and enable OK button
        /// </summary>
        private void CheckIt(object sender, EventArgs e)
        {
            //if ((textBox1.Text == null || textBox1.Text == "")) // if username = empty
            //{
            //    textBox2.Text = null;
            //    button2.Enabled = true;
            //}
            if (!(textBox1.Text==null) && !(textBox1.Text == "") && !(textBox2.Text == null) && !(textBox2.Text == "")) // If both fields are filled
            {
                if (!(textBox2.Text.IndexOf(" ") == -1)) //No space allowed
                {
                    button2.Enabled = false;
                    Mess.Visible = true;
                }
                else
                {
                    button2.Enabled = true;
                    Mess.Visible = false;
                }
            }
            else
            {
                button2.Enabled = false;
                //button1.Focus();
                //button1.Select();
                if (((textBox1.Text == null) || (textBox1.Text == "")) && ((textBox2.Text == null) || (textBox2.Text == "")))
                {
                    button2.Enabled = true;
                }
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
