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
    public partial class FishyNote : Form
    {
        #region Data Members

        bool _shrink = false;
        bool _fishyNoteBoxClickedOnce = true;

        RemoveFishyNotes closeFishyNote;

        #endregion

        public int FrmID
        {
            get;
        }

        /// <summary>
        /// Property storing the fish note texts
        /// </summary>
        public List<String> FishNoteTexts { get; set; } = new List<string>();

        /// <summary>
        /// Default Constrcutor
        /// </summary>
        public FishyNote(int id, RemoveFishyNotes close)
        {
            InitializeComponent();
            FrmID = id;
            closeFishyNote = close;
        }

        /// <summary>
        /// Button which closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FishNoteTexts.Add(txtNoteTexts.Text);
            closeFishyNote();
            Dispose();
        }

        private void btnCollapseOpen_Click(object sender, EventArgs e)
        {
            _shrink = !_shrink;

            if (_shrink)
            {
                Size = new Size(800, 190);
            }
            else
            {
                Size = new Size(816, 489);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (_fishyNoteBoxClickedOnce)
            {
                _fishyNoteBoxClickedOnce = false;
                txtNoteTexts.Text = "";
            }
            else
            {
                //automagically += txtNoteTexts.Text;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //automagically += txtNoteTexts.Text;
        }

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
    }
}
