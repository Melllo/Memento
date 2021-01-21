using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Memento
{
    class TextOriginator
    {

        private string filePath =  "text.txt";
        private string text;
        private DateTime date;

        public void setTextAndDate(String txt) {
            this.text = txt;
            this.date = new DateTime();
            writeText(text);
        }

        private void writeText(string text) {
            using (StreamWriter writer = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                writer.WriteLine(text);
            }
        }

        public TextMemento Save() {
            return new TextMemento(text);
        }

        public void Load(TextMemento save) {
            this.text = save.Text;
            this.date = save.Date;
            writeText(text);
        }
        public override String ToString() {
            return "Text: \n" + text + "\nDate: \n" + date;
        }


    }
}
