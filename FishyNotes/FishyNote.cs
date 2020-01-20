using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
    public partial class FishyNote : Form
    {
        bool shrink = false;

        string automagically = "";

        public FishyNote()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCollapseOpen_Click(object sender, EventArgs e)
        {
            shrink = !shrink;

            if (shrink)
            {
                Size = new Size(454, 234);
            }
            else
            {
                Size = new Size(816, 489);
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            automagically = textBox1.Text;
        }
    }
}
