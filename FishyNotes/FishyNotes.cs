using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace FishyNotes
{
    public partial class frm_FishyNotes : Form
    {
        #region Data Members

        private frm_FishyNote _frmFishyNote;

        INoteData _noteData = new NoteData();

        INoteText _noteText = new NoteData();

IList<String> fishAss = new List<string>();

        IModel img = new Model();

        #endregion

        public frm_FishyNotes()
        {
            InitializeComponent();

            fishAss = img.load(Directory.GetFiles("FishAssets/").ToList());
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
            Random random = new Random();

            int i = random.Next(0, fishAss.Count - 1);

            // Create new instance of FishyNote passing delegate methods
            _frmFishyNote = new frm_FishyNote(
                _noteData.RemoveFishyNote, _noteData.AddFishyNoteText,
                _noteText.ReplaceFishyNoteText, _noteText.RetriveFishyNoteText, img.getImage(fishAss[i],0,0));

            // Add to dictionary, key is the ID generated in the Fishy Class
            //_noteText.Add(_frmFishyNote.ID, _frmFishyNote);

            
        }

        #endregion
        
    }
}