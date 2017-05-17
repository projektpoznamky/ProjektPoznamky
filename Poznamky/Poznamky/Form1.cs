using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //Globální proměnné pro uložení textu z NameTextBox & NoteTextBox
        private string name;
        private string noteText;
        private DB db = new DB(); 

        //ArrayList pro uložení poznámek načtených z tlačítka SendNote_Button
        ArrayList notes = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }



        public void Form1_Load(object sender, EventArgs e)
        {

            //db.db_connect(); //volání připojení dtb
            //Při načtení formu se schová tlačítko pro smazání a smazání všeho
            DeleteNote_Button.Visible = false;
            DeleteAllNotes_Button.Visible = false;
        }




        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {   
            //Zapisuje text napsaný do NameTextBox-u do proměnné name
            name = NameTextBox.Text;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            //Zapisuje text napsaný do NoteTextBox-u do proměnné noteText
            noteText = NoteTextBox.Text;
        }

        private void SendNote_Button_Click(object sender, EventArgs e)
        {
            addNote();
            list();
        }

        private void list()
        {
            //Vypíše všechny poznamky uložené v ArrayListu notes
            Poznamka p;
            ShowNote_ListBox.Items.Clear();
            for (int i = 0; i < notes.Count; i++)
            {
                p = (Poznamka)notes[i];
                ShowNote_ListBox.Items.Add("Jméno: " + p.getName() + "     Obsah: " + p.getText());
            }
        }

        private void addNote()
        {
            //Vytvoří nový objekt Poznamka a přidá ho do ArrayListu
            Poznamka note;
            note = new Poznamka(name, noteText);
            notes.Add(note);
            db.add_note_db(note);
        }





        private void DeleteNote_Button_Click(object sender, EventArgs e)
        {
            //Pokud je v ArrayListu notes poslední poznámka, tak po kliku na tlačítko pro smazání se tyto tlačítka schovají
            if (notes.Count == 1)
            {
                DeleteNote_Button.Visible = false;
                DeleteAllNotes_Button.Visible = false;
            }

            //cyklus se opakuje i-krát (velikost ArrayListu notes)
            for (int i = 0; i < notes.Count; i++)
            {   
                //Pokud i-tá poznámka je vybrána uživatelem před tím, než klikl na tlačítko 'Smazat' tak se tato poznámka smaže
                if (ShowNote_ListBox.GetSelected(i))
                {
                    notes.RemoveAt(i);
                }
            }
            list();
        }

        private void DeleteAllNotes_Button_Click(object sender, EventArgs e)
        {
            //Vyprázdní celý ArrayList notes
            notes.Clear();
            list();
        }

    }
}
