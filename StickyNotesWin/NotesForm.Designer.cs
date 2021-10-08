
namespace StickyNotesWin
{
    partial class NotesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
            
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.NotesTxt = new System.Windows.Forms.RichTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.FocusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotesTxt
            // 
            this.NotesTxt.BackColor = System.Drawing.Color.DarkKhaki;
            this.NotesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesTxt.Location = new System.Drawing.Point(12, 32);
            this.NotesTxt.Name = "NotesTxt";
            this.NotesTxt.Size = new System.Drawing.Size(276, 290);
            this.NotesTxt.TabIndex = 1;
            this.NotesTxt.Text = "";
            this.NotesTxt.Click += new System.EventHandler(this.NotesTxt_Click);
            this.NotesTxt.TextChanged += new System.EventHandler(this.NotesTxt_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(12, 328);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(80, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FocusLbl
            // 
            this.FocusLbl.AutoSize = true;
            this.FocusLbl.Location = new System.Drawing.Point(187, 403);
            this.FocusLbl.Name = "FocusLbl";
            this.FocusLbl.Size = new System.Drawing.Size(0, 15);
            this.FocusLbl.TabIndex = 2;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.FocusLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NotesTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1010, 110);
            this.Name = "NotesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Activated += new System.EventHandler(this.NotesForm_Activated);
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.Click += new System.EventHandler(this.NotesForm_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotesForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotesForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotesTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label FocusLbl;
    }
}

