using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.TextEditorApp
{
    internal class TextEditor2
    {

        public string content;

        public void write(string text)
        {
            content = text;
        }
        public void read()
        {
            Console.WriteLine(content);
        }

        public TextEditorMomento save()
        {
            return new TextEditorMomento(content);
        }
        public void restore(TextEditorMomento tt)
        {
               content= tt.content; 
        }
    }
}

