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
    public partial class FishyNotes : Form
    {
        public FishyNotes()
        {
            InitializeComponent();
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            FishyNote _frmNote = new FishyNote();
            _frmNote.Show();
        }
    }
}
