namespace FishyNotes
{
    partial class frm_FishyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddNote.FlatAppearance.BorderSize = 0;
            this.btn_AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNote.Location = new System.Drawing.Point(12, 12);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(205, 47);
            this.btn_AddNote.TabIndex = 0;
            this.btn_AddNote.Text = "More Fish";
            this.btn_AddNote.UseVisualStyleBackColor = false;
            this.btn_AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // frm_FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(229, 71);
            this.Controls.Add(this.btn_AddNote);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 110);
            this.MinimumSize = new System.Drawing.Size(245, 110);
            this.Name = "frm_FishyNotes";
            this.Text = "FishyNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNote;
    }
}

