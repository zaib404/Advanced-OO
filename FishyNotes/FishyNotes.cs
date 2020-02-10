using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FishyNotes
{
    public partial class frm_FishyNotes : Form
    {
        #region Data Members

        private frm_FishyNote _frmFishyNote;

        INoteData _noteData = new NoteData();

        INoteText _noteText = new NoteData();

        #endregion

        public frm_FishyNotes()
        {
            InitializeComponent();
        }

        #region Form Events

        /// <summary>
        /// Creates new instance of Fishy Note passsing in two delegates
        /// And adding them to the _notes dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            IModel img = new ImageLoader();

            // Create new instance of FishyNote passing delegate methods
            _frmFishyNote = new frm_FishyNote(
                _noteData.RemoveFishyNote, _noteData.AddFishyNoteText,
                _noteText.ReplaceFishyNoteText, _noteText.RetriveFishyNoteText, img.RandomImage());

            // Add to dictionary, key is the ID generated in the Fishy Class
            //_noteText.Add(_frmFishyNote.ID, _frmFishyNote);

            
        }

        #endregion
        
    }
}