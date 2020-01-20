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
    public partial class frm_FishyNotes : Form
    {
        FishyNote _frmNote;
        bool clickedOnce = true;

        public frm_FishyNotes()
        {
            InitializeComponent();
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            if (clickedOnce)
            {
                _frmNote = new FishyNote();
                //clickedOnce = false;
            }
            else
            {
                //int i = _frmNote.FishNoteTexts.Count-1;
               // _frmNote = new FishyNote(_frmNote.FishNoteTexts[i]);
            }

            _frmNote.ShowDialog();

        }
    }
}
