namespace FishyNotes
{
    partial class FishyNote
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCollapseOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNoteTexts
            // 
            this.txtNoteTexts.Location = new System.Drawing.Point(143, 231);
            this.txtNoteTexts.Multiline = true;
            this.txtNoteTexts.Name = "txtNoteTexts";
            this.txtNoteTexts.Size = new System.Drawing.Size(645, 207);
            this.txtNoteTexts.TabIndex = 0;
            this.txtNoteTexts.Text = "Enter your note here...";
            this.txtNoteTexts.Click += new System.EventHandler(this.textBox1_Click);
            this.txtNoteTexts.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCollapseOpen
            // 
            this.btnCollapseOpen.Location = new System.Drawing.Point(13, 13);
            this.btnCollapseOpen.Name = "btnCollapseOpen";
            this.btnCollapseOpen.Size = new System.Drawing.Size(279, 168);
            this.btnCollapseOpen.TabIndex = 2;
            this.btnCollapseOpen.UseVisualStyleBackColor = true;
            this.btnCollapseOpen.Click += new System.EventHandler(this.btnCollapseOpen_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNoteTexts);
            this.Controls.Add(this.btnCollapseOpen);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoteTexts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCollapseOpen;
    }
}