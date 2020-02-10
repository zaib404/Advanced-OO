using System;
using System.Drawing;
using System.Windows.Forms;

namespace FishyNotes
{
    public partial class frm_FishyNote : Form
    {
        #region Data Members

        // Storing the default text when the form loads
        string _defaultText;

        // shrink the form to minimum size or max size
        bool _shrink = false;

        // Delegate Methods
        DelegateRemoveFishyNotes _removeFishyNotes;
        DelegateAddNoteText _AddNoteText;
        DelegateReplaceNoteText _replaceNoteText;
        DelegateRetriveNoteText _retrieveNoteText;

        #endregion

        #region Properties

        /// <summary>
        /// Set a new ID for each new form that opens
        /// </summary>
        public Guid ID
        {
            get;
        } = Guid.NewGuid();

        #endregion

        #region Code Snippet: makes this borderless window movable

        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="delegateRemoveFishy">Reference to the delegate method to remove from list in FishyNotes</param>
        /// <param name="delegateGetNote"></param>
        public frm_FishyNote(DelegateRemoveFishyNotes delegateRemoveFishy, DelegateAddNoteText delegateAddNoteText, 
            DelegateReplaceNoteText delegateReplaceNoteText, DelegateRetriveNoteText delegateRetriveNoteText, Image image)
        {
            InitializeComponent();

            btnCollapseOpen.Image = image;

            // Store default text
            _defaultText = txtNoteTexts.Text;

            // Pointers for Delegate Methods
            _removeFishyNotes = delegateRemoveFishy;

            _replaceNoteText = delegateReplaceNoteText;

            _retrieveNoteText = delegateRetriveNoteText;

            _AddNoteText = delegateAddNoteText;

            _AddNoteText(ID, txtNoteTexts.Text);

            // Open Form
            Show();
        }

        /// <summary>
        /// Removes reference from FishyNotes and Disposes everything in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            _removeFishyNotes(ID);

            Dispose();
        }

        private void btnReplaceText_Click(object sender, EventArgs e)
        {
            //replace delegate
            _replaceNoteText(ID, txtNoteTexts.Text);
        }

        /// <summary>
        /// When clicking the button the form will either return to minimum size
        /// or max size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCollapseOpen_Click(object sender, EventArgs e)
        {
            // Set _shrink to the opposite of what it currently is
            _shrink = !_shrink;

            if (_shrink)
            {
                Size = MinimumSize;
                txtNoteTexts.Visible = false;
            }
            else
            {
                Size = MaximumSize;
                txtNoteTexts.Visible = true;
            }
        }

        /// <summary>
        /// Used to check if the text inside the textbox is the default text then
        /// clear the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNoteTexts_Click(object sender, EventArgs e)
        {
            if (txtNoteTexts.Text == _defaultText)
            {
                txtNoteTexts.Text = "";
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            txtNoteTexts.Text = _retrieveNoteText(ID);
        }
    }
}
