using MySql.Data.MySqlClient;
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
        private Poznamka note;
        private int location;

        //ArrayList pro uložení poznámek načtených z tlačítka SendNote_Button
        ArrayList notes = new ArrayList();

        public Form1()
        {
            
            InitializeComponent();
            db.db_connect(); //připoj se na dtb
            list_load(); //načti všechen obsah z dtb
        }



        public void Form1_Load(object sender, EventArgs e)
        {

            //db.db_connect(); //volání připojení dtb
            //Při načtení formu se schová tlačítko pro smazání a smazání všeho
            
            DeleteNote_Button.Visible = false;
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
            addNote(); //přidej do array listu
            list(); //vypiš
        }

        private void list_load()
        {
            //provádí se na začátku --> načte vše z dtb a vytvoří instance a přidá do array listu notes
            MySqlDataReader reader;
            
            
            reader = db.db_select_notes();

            while (reader.Read())
            {
                //vytvoř instanci
                note = new Poznamka(reader.GetString("id_note"), reader.GetString("name_note"), reader.GetString("text_note"), reader.GetString("date_note"));
                notes.Add(note); //přidej do array listu
                ShowNote_ListBox.Items.Add("Jméno: " + reader.GetString("name_note") + "    Obsah: " + reader.GetString("text_note"));
            }
            db.db_close(); //ukončení komunikace s dtb zahájené v db.db_select_notes()
        }




        private void list()
        {
            ShowNote_ListBox.Items.Clear(); //vyčisti zobrazené položky
            MySqlDataReader reader;
            reader = db.db_select_notes(); //získej výpis všeho

            while (reader.Read()){
                //vypiš vše
                note = new Poznamka(reader.GetString("id_note"), reader.GetString("name_note"), reader.GetString("text_note"), reader.GetString("date_note"));
                notes.Add(note); //přidej do array listu
                ShowNote_ListBox.Items.Add("Jméno: " + reader.GetString("name_note") + "    Obsah: " + reader.GetString("text_note"));
            }





            /*Vypíše všechny poznamky uložené v ArrayListu notes
            Poznamka p;
            ShowNote_ListBox.Items.Clear();
            for (int i = 0; i < notes.Count; i++)
            {
                p = (Poznamka)notes[i];
                ShowNote_ListBox.Items.Add("Jméno: " + p.getName() + "     Obsah: " + p.getText());
            }*/
        }

        private void addNote()
        {
            //Vytvoří nový objekt Poznamka a přidá ho do ArrayListu
            note = new Poznamka(name, noteText);
            db.add_note_db(note);
            notes.Clear();
            list();
        }





        private void DeleteNote_Button_Click(object sender, EventArgs e)
        {
            //Pokud je v ArrayListu notes poslední poznámka, tak po kliku na tlačítko pro smazání se tyto tlačítka schovají
            if (notes.Count == 1)
            {
                DeleteNote_Button.Visible = false;
            }


            location = ShowNote_ListBox.SelectedIndex;

                
            note = (Poznamka)notes[location];
            int id_note = note.getId();
            db.db_delete_note(id_note);
                
            
            list();
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ShowNote_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = ShowNote_ListBox.SelectedIndex;
            label1.Text = location.ToString();
        }

        private void UpdateNote_Button_Click(object sender, EventArgs e)
        {
            Form_Update form_Update = new Form_Update();
            location = ShowNote_ListBox.SelectedIndex;
            this.Visible = false;

            note = (Poznamka)notes[location];
            int id_note = note.getId();

            form_Update.setName(note.getName());
            form_Update.setNote(note.getText());
            form_Update.Show();
        }

        
    }
}
