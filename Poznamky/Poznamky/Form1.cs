using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private int charNumber = 2000;
        private String chars;
        private int size;
        private string username, password;

        //ArrayList pro uložení poznámek načtených z tlačítka SendNote_Button
        ArrayList notes = new ArrayList();

        public Form1()
        {
            
            InitializeComponent();
            this.ActiveControl = usernameTextBox;
            db.db_connect(); //připoj se na dtb
            list_load(); //načti všechen obsah z dtb
            //Při načtení formu se schová tlačítko pro smazání a smazání všeho
            DeleteNote_Button.Visible = false;
            
            this.usernameTextBox.TextAlign = HorizontalAlignment.Center;
            this.passwordTextBox.TextAlign = HorizontalAlignment.Center;
            this.passwordTextBox.PasswordChar = '*'; 

            
        }



        public void Form1_Load(object sender, EventArgs e)
        {

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
            NoteTextBox.Focus();



            //Zařizuje počítání znaků do poznámky
            chars = NoteTextBox.Text;
            size  = chars.Length;
            charNumber -= size;
            TextLengthCounter.Text = charNumber.ToString();


            if(charNumber < 1)
            {
                TextLengthCounter.Text = "Chyba";
            }

            charNumber = 2000;

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
            if (location >= 0)
            {
                note = (Poznamka)notes[location];
                form_Update.setId(note.getId());
                form_Update.setName(note.getName());
                form_Update.setNote(note.getText());
                form_Update.Show();
                this.Visible = false;

            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Button_MouseHover(object sender, EventArgs e)
        {
            this.Close_Button.BackColor = Color.Red;
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            this.Close_Button.BackColor = Color.Transparent;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Button_MouseHover(object sender, EventArgs e)
        {
            this.Close_Button.BackColor = Color.AliceBlue;

            if((username != null && username.Length < 51) && (password != null && password.Length < 41))
            {
                //metoda pro login
            } else
            {
                //špatné přihlášení
            }

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }
    }
    }

