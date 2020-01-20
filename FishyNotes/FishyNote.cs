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
        bool shrink = false;
        bool textBoxClickedOnce = true;

        string automagically = "";

        public FishyNote()
        {
            InitializeComponent();
        }

        //public FishyNote(string FishNoteText)
        //{
        //    InitializeComponent();

        //    txtNoteTexts.Text = FishNoteText;
        //}

        public List<String> FishNoteTexts { get; set; } = new List<string>();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //FishNoteTexts.Add(automagically);
            Dispose();
        }

        private void btnCollapseOpen_Click(object sender, EventArgs e)
        {
            shrink = !shrink;

            if (shrink)
            {
                Size = new Size(454, 234);
            }
            else
            {
                Size = new Size(816, 489);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBoxClickedOnce)
            {
                textBoxClickedOnce = false;
                txtNoteTexts.Text = "";
            }
            else
            {
                automagically += txtNoteTexts.Text;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            automagically += txtNoteTexts.Text;
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
