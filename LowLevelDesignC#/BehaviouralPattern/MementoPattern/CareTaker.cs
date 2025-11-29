using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern
{

    //CareTaker class : manage momentos or history 
    internal class CareTaker
    {

        public Stack<TextEditorMomento> history = new Stack<TextEditorMomento>();

        public void save(TextEditor2 edit)
        {
            history.Push(edit.save());
        }
        public void undo(TextEditor2 edit) { 
        
        if(history.Count > 0)
            {
                history.Pop();
                edit.restore(history.Peek());
            }
        }

    }
}
