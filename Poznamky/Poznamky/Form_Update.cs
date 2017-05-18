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
        public Form_Update()
        {
            InitializeComponent();
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setNote(string note)
        {
            this.note = note;
        }
    }

}
