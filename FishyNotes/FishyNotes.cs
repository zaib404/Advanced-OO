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
        #region

        FishyNote _frmNote;

        bool _clickedOnce = true;

        #endregion

        public frm_FishyNotes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Add Note Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            // if clicked once true
            if (_clickedOnce)
            {
                _frmNote = new FishyNote();
                _clickedOnce = false;
            }
            else
            {
                int i = _frmNote.FishNoteTexts.Count - 1;
                _frmNote = new FishyNote(_frmNote.FishNoteTexts[i]);
            }

            _frmNote.ShowDialog();

        }
    }
}
