﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
    /// <summary>
    /// Delegate used to remove FishyNote from dictionary
    /// </summary>
    /// <param name="frmID">Key used to remove from dictionary</param>
    public delegate void DelegateRemoveFishyNotes(Guid frmID);

    public delegate void DelegateAddNoteText(Guid guid, string text);

    public delegate String DelegateRetriveNoteText(Guid guid);

    public delegate void DelegateReplaceNoteText(Guid guid, string text);

}
