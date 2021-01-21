using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class TextCaretaker
    {
        private TextMemento Save;

        public void setSave(TextMemento textMemento) {
            this.Save = textMemento;
        }
        public TextMemento getSave() {
            return Save;
        }

    }
}
