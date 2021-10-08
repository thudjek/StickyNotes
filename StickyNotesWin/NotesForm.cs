using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace StickyNotesWin
{
    public partial class NotesForm : Form
    {
        private Point currentMouseLocation;
        private string currentSavedText = "";
        private int noteId = 0;
        public NotesForm()
        {
            InitializeComponent();

            var note = DatabaseHelper.LoadNote();
            if (note != null)
            {
                noteId = note.Id;
                NotesTxt.Text = note.Content;
                currentSavedText = note.Content;
                NotesTxt.Select(NotesTxt.Text.Length, 0);
            }

            Location = new Point(1070, 120);
            NotesTxt.ReadOnly = true;
            SaveBtn.Visible = false;
            
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            ActiveControl = FocusLbl;
        }

        private void NotesForm_Click(object sender, EventArgs e)
        {
            ActiveControl = FocusLbl;
        }

        private void NotesForm_Activated(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void NotesForm_MouseMove(object sender, MouseEventArgs e)
        {
            var currentMousePosition = PointToClient(Cursor.Position);

            if (IsMousePositionValidForMoving(currentMousePosition))
            {
                Cursor = Cursors.SizeAll;
                if (e.Button == MouseButtons.Left)
                    MoveFormWithMouse(e);
            }
            else
                Cursor = Cursors.Default;
        }

        private void NotesForm_MouseDown(object sender, MouseEventArgs e)
        {
            currentMouseLocation = PointToClient(Cursor.Position);
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void NotesTxt_TextChanged(object sender, EventArgs e)
        {
            ShowSaveButtonIfTextChanged();
        }

        private void NotesTxt_Click(object sender, EventArgs e)
        {
            if (NotesTxt.ReadOnly)
            {
                NotesTxt.ReadOnly = false;
                NotesTxt.Focus();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            currentSavedText = NotesTxt.Text;
            var note = new Note() { Id = noteId, Content = currentSavedText };
            DatabaseHelper.SaveNote(note);
            ShowSaveButtonIfTextChanged();
            NotesTxt.ReadOnly = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (ActiveControl == FocusLbl && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsMousePositionValidForMoving(Point point)
        {
            return point.X >= 5 && point.X <= 295 && point.Y >= 0 && point.Y <= 30;
        }

        private void MoveFormWithMouse(MouseEventArgs e)
        {
            int dx = e.Location.X - currentMouseLocation.X;
            int dy = e.Location.Y - currentMouseLocation.Y;
            Location = new Point(Location.X + dx, Location.Y + dy);
        }

        private void ShowSaveButtonIfTextChanged()
        {
            SaveBtn.Visible = currentSavedText != NotesTxt.Text;
        }
    }
}
