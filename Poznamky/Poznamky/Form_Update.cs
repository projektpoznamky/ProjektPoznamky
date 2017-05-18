using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poznamky
{
    public partial class Form_Update : Form
    {
        private string name, note;
        private int id;
        private DB db = new DB();
        public Form_Update()
        {
            InitializeComponent();
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = name;
            NoteTextBox.Text = note;
            
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setNote(string note)
        {
            this.note = note;
        }


        private void Back_Form1_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.name = NameTextBox.Text;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            this.note = NoteTextBox.Text;
        }

        private void NoteUpdate_Button_Click(object sender, EventArgs e)
        {
            db.db_update_note(id, name, note);
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        
    }

}
