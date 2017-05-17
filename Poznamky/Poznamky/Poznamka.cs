namespace Poznamky
{
    internal class Poznamka
    {
        private string name;
        private string text;

        public Poznamka(string name, string text){
            this.name = name;
            this.text = text;
        }

        public string getName()
        {
            return this.name;
        }

        public string getText()
        {
            return this.text;
        }
    }
}