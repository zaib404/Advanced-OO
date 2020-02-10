using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyNotes
{
    interface INoteData
    {
        void AddFishyNoteText(Guid id, string noteText);

        void RemoveFishyNote(Guid frmID);
    }
}
