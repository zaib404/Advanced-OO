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

        private IDictionary<Guid, Form> _notes = new Dictionary<Guid, Form>();

        private IDictionary<Guid, string> _noteText = new Dictionary<Guid, string>();

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
            // Create new instance of FishyNote passing delegate methods
            _frmFishyNote = new frm_FishyNote(RemoveFishyNote, RetrieveFishyNoteText);

            // Add to dictionary, key is the ID generated in the Fishy Class
            _notes.Add(_frmFishyNote.ID, _frmFishyNote);
        }

        #endregion

        #region Methods

        private void RetrieveFishyNoteText(Guid id, string noteText)
        {
            _noteText.Add(id, noteText);
        }

        /// <summary>
        /// Called when the FishyNote Form is closing it
        /// Removes FishNote from Dictionary
        /// </summary>
        /// <param name="frmID">Dictionary key</param>
        private void RemoveFishyNote(Guid frmID)
        {
            _notes.Remove(frmID);

            //test.RemoveAt(test.ToList().FindIndex(x => x.ID == frmID));

        }

        #endregion
    }
}