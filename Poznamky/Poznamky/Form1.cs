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
        private string note;
        ArrayList poznamky = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = NameTextBox.Text;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            note = NoteTextBox.Text;
        }

        private void SendNote_Button_Click(object sender, EventArgs e)
        {
            Vypsat();
        }

        private void Vypsat()
        {

        }
    }
}
/*
    public partial class Form1 : Form {
        private static String nameText;
        private static String text;
        ArrayList poznamky = new ArrayList();
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Button_Smazat.Visible = false;
            Button_Smazat_Vse.Visible = false;
            this.label1.MaximumSize = new Size(250, 0);
            this.label1.AutoSize = true;
        }

        private void Jmeno_TextBox_TextChanged(object sender, EventArgs e) {
            nameText = this.Jmeno_TextBox.Text;  
        }


        private void Text_TextBox_TextChanged(object sender, EventArgs e) {
            text = this.Text_TextBox.Text;
        }

        private void Button_Pridat_Click(object sender, EventArgs e)
        {
            pridatPoznamku();
            vypsat();
            Button_Smazat.Visible = true;
            Button_Smazat_Vse.Visible = true;

        }

        private void Button_Smazat_Click(object sender, EventArgs e) {
            if(poznamky.Count == 1) {
                Button_Smazat.Visible = false;
                Button_Smazat_Vse.Visible = false;
            }

            for (int i = 0; i < poznamky.Count; i++) {
                    if (Vypis_ListBox.GetSelected(i)) {
                        poznamky.RemoveAt(i);
                    }
                }
           
            vypsat();
        }

        private void Button_Smazat_Vse_Click(object sender, EventArgs e)
        {
            poznamky.Clear();
            vypsat();
        }

        private void vypsat()
        {
            Poznamka p;
            Vypis_ListBox.Items.Clear();
            for (int i = 0; i < poznamky.Count; i++)
            {
                p = (Poznamka)poznamky[i];
                Vypis_ListBox.Items.Add("Jméno: " + p.getName() + "     Obsah: " + p.getText());
            }
        }

        private void pridatPoznamku()
        {
            Poznamka poznamka;
            poznamka = new Poznamka(nameText, text);
            poznamky.Add(poznamka);
        }
    }
}
*/