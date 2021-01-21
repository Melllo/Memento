using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text!\n");

            TextOriginator txt = new TextOriginator();
            TextCaretaker ct = new TextCaretaker();

            string s = Console.ReadLine();
            txt.setTextAndDate(s);
            Console.WriteLine(txt.ToString());
            ct.setSave(txt.Save());

            Console.WriteLine("\nEnter new text!\n");
            s = Console.ReadLine();
            txt.setTextAndDate(s);

            Console.WriteLine(txt.ToString());

            txt.Load(ct.getSave());

            Console.WriteLine("\nRollback!\n");

            Console.WriteLine(txt.ToString());

        }
    }
}
