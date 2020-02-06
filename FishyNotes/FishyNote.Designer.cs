namespace FishyNotes
{
    partial class frm_FishyNote
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
            this.txtNoteTexts = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCollapseOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNoteTexts
            // 
            this.txtNoteTexts.Location = new System.Drawing.Point(12, 128);
            this.txtNoteTexts.Multiline = true;
            this.txtNoteTexts.Name = "txtNoteTexts";
            this.txtNoteTexts.Size = new System.Drawing.Size(357, 212);
            this.txtNoteTexts.TabIndex = 0;
            this.txtNoteTexts.Text = "Enter your note here...";
            this.txtNoteTexts.Click += new System.EventHandler(this.txtNoteTexts_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(328, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCollapseOpen
            // 
            this.btnCollapseOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCollapseOpen.FlatAppearance.BorderSize = 0;
            this.btnCollapseOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapseOpen.Location = new System.Drawing.Point(12, 12);
            this.btnCollapseOpen.Name = "btnCollapseOpen";
            this.btnCollapseOpen.Size = new System.Drawing.Size(170, 110);
            this.btnCollapseOpen.TabIndex = 2;
            this.btnCollapseOpen.UseVisualStyleBackColor = false;
            this.btnCollapseOpen.Click += new System.EventHandler(this.btnCollapseOpen_Click);
            // 
            // frm_FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(381, 352);
            this.Controls.Add(this.txtNoteTexts);
            this.Controls.Add(this.btnCollapseOpen);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(381, 352);
            this.MinimumSize = new System.Drawing.Size(238, 134);
            this.Name = "frm_FishyNote";
            this.Text = "FishyNote";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoteTexts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCollapseOpen;
    }
}