using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class TextMemento
    {
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public TextMemento(string text)
        {
            this.Text = text;
            this.Date = new DateTime();
        }
    }
}
