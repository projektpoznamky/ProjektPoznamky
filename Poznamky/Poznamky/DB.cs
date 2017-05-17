using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Poznamky
{
    class DB
    {
        private MySqlConnection connection;
        private MySqlCommand command;
       

        public DB()
        {
            
        }

        public void db_connect()
        {       //připojit se do dtb

                //připojit na local dtb
                connection = new MySqlConnection("Server=10.0.7.17; Port=3306; Database=projektpoznamky; Uid=poznamky; Pwd=12345");
                connection.Open(); //otevřít dtb

        }


        public void add_note_db(Poznamka note)
        { //přidat novou poznámku do databáze

            db_connect(); //pro každý nový příkaz musí být nové připojení do dtb

            command = connection.CreateCommand(); //zahájit vytváření příkazu

            //získat hodnoty z přidaného objektu
            String name_note = note.getName();
            String text_note = note.getText();

            command.CommandText = "INSERT INTO notes(name_note, text_note) VALUES('"+name_note+"', '"+text_note+"')"; //znění příkazu

            command.ExecuteNonQuery(); //provést

            db_close(); //ukončit dtb

           
                
        }

        public void db_close()
        {   //ukončit komunikaci s databází
            connection.Close();
        }




        

        

    }



}
