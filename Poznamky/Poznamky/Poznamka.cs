namespace Poznamky
{
    internal class Poznamka
    {
        private string name;
        private string text;
        private int id;
        private string date;

        public Poznamka(string name, string text)
        {
            this.name = name;
            this.text = text;
        }
        public Poznamka (string id, string name, string text, string date){
            this.id = int.Parse(id);
            this.name = name;
            this.text = text;
            this.date = date;
        }

        public string getName()
        {
            return this.name;
        }

        public string getText()
        {
            return this.text;
        }

        public int getId(){
            return this.id;
        }

        public void setId(string id)
        {
            this.id = int.Parse(id);
        }

        public string getDate()
        {
            return this.date;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

    }
}