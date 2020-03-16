using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
    class NoteData : INoteData, INoteText
    {
        private IDictionary<Guid, Form> _notes = new Dictionary<Guid, Form>();

        private IDictionary<Guid, string> _noteText = new Dictionary<Guid, string>();

        public NoteData()
        {

        }

        /// <summary>
        /// Called when the FishyNote Form is closing it
        /// Removes FishNote from Dictionary
        /// </summary>
        /// <param name="frmID">Dictionary key</param>
        public void RemoveFishyNote(Guid frmID)
        {
            _notes.Remove(frmID);
        }

        public void AddFishyNoteText(Guid id, string noteText)
        {
            _noteText.Add(id, noteText);
        }

        public void ReplaceFishyNoteText(Guid id, string text)
        {
            _noteText[id] = text;
        }

        public string RetriveFishyNoteText(Guid id)
        {
            return _noteText[id];
        }

    }
}
