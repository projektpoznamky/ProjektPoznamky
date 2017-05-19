using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.AccessControl;

namespace Poznamky
{
    class DB
    {
        private MySqlConnection connection;
        private MySqlCommand command;
       

        public DB()
        {
            //db_connect(); //hned při vytvoření instance se připoj do dtb
            
        }

        public void db_connect()
        {       //připojit se do dtb

                //připojit na local dtb
                connection = new MySqlConnection("Server=10.0.7.17; Port=3306; Database=projektpoznamky; Uid=poznamky; Pwd=12345");
                connection.Open(); //otevřít dtb
        }
        public void db_close()
        {   //ukončit komunikaci s databází
            connection.Close();
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




        public MySqlDataReader db_select_notes()
        {
            db_connect(); //připojit se
            command = connection.CreateCommand();

           // command.CommandText = "SELECT id_note, name_note, text_note, date_note FROM notes";

            string select = "SELECT id_note, name_note, text_note, date_note FROM notes";

            MySqlCommand cmd = new MySqlCommand(select, connection);
           MySqlDataReader reader = cmd.ExecuteReader();
            //nesmím zavřít dtb jinak by se nevykonal reader v Form1.cs
            
            return reader;
        }


        public void db_delete_note(int id_note)
        {
            db_connect();

            string delete = "DELETE FROM notes WHERE id_note = " + id_note;

            MySqlCommand cmd = new MySqlCommand(delete, connection);
            cmd.ExecuteNonQuery();

            db_close();

            
        }


        public void db_update_note(int id_note, string name_note, string text_note)
        {
            //update dané poznámky, předá se mi z formuláře id, jméno a text
            db_connect();

            string update = "UPDATE notes SET name_note = '" + name_note + "', text_note ='" + text_note + "' WHERE id_note =" + id_note;

            MySqlCommand cmd = new MySqlCommand(update, connection);

            cmd.ExecuteNonQuery();

            db_close();

        }


        public int db_login(String username, String password)
        {
            db_connect();

            string passwd = getSHA1(password);

            string select_login = "SELECT id_user FROM users WHERE username = '" + username + "' AND password = '" + passwd +"'";

            MySqlCommand cmd = new MySqlCommand(select_login, connection);

            int count = (int)cmd.ExecuteScalar();

            if(count == 1)
            {
                int id_user = 0;
                // cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_user = int.Parse(reader.GetString("id_user"));
                }
                db_close();
                return id_user;

            }
            else
            {
                db_close();
                return 0;
            }
            

            


            
        }

      /*  public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }*/



        public string getSHA1(string text)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();

            foreach(byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();

        }









    }



}
