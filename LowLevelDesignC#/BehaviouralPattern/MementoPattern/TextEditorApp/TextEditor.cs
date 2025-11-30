using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.TextEditorApp
{

    //Problem : Designing a undo/redo functionality in this text editor 
    //First 

    //Voilation of Single Responsibilty principle where text editor is also handling undo and redo
    public class TextEditor
    {
        private string content;

        public Stack<string> history;
        public Stack<string> redoBackup;

        public TextEditor()
        {
            history=new Stack<string>(); 
            redoBackup=new Stack<string>();

        }
        public void write(string text)
        {

            history.Push(text);//pushing element 
            content =  text;
        }
        public void read() { 
        Console.WriteLine(content);
        }

        public void undo()
        {
            redoBackup.Push(history.Peek()); //pushing element to another container before removing from history
            history.Pop();
            
            content = history.Peek();
        }
        public void redo() {

            history.Push(redoBackup.Peek()); // again pushing back to history stack
           redoBackup.Pop();
            content=history.Peek();
        }
    }
}
