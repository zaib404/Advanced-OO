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
            this.btn_AddNote.Location = new System.Drawing.Point(30, 35);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(132, 61);
            this.btn_AddNote.TabIndex = 0;
            this.btn_AddNote.Text = "More Fish";
            this.btn_AddNote.UseVisualStyleBackColor = true;
            this.btn_AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // frm_FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 115);
            this.Controls.Add(this.btn_AddNote);
            this.Name = "frm_FishyNotes";
            this.Text = "FishyNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNote;
    }
}

