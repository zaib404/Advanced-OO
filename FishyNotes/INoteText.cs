using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyNotes
{
    interface INoteText
    {
        string RetriveFishyNoteText(Guid id);

        void ReplaceFishyNoteText(Guid id, string text);
    }
}
