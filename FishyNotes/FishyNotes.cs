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
        #region Data Members

        Dictionary<int, Form> _frmNotes = new Dictionary<int, Form>();

        int _frmCounter;

        RemoveFishyNotes removeNotes;

        #endregion

        public frm_FishyNotes()
        {
            InitializeComponent();

            removeNotes = new RemoveFishyNotes(RemoveFishNote);
        }

        /// <summary>
        /// Click Add Note Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            removeNotes = RemoveFishNote;

            _frmNotes.Add(_frmCounter++, new FishyNote(_frmCounter, removeNotes));
            
            _frmNotes[_frmNotes.Count - 1].Show();
        }

        private void RemoveFishNote()
        {
            _frmNotes.Remove(_frmCounter-1);
        }
    }
}
