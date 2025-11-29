using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.GraphicEditorApp
{
    internal class CareTaker
    {
        private Stack<GraphicEditMomento> editMomentoStack;
        public CareTaker()
        {
            editMomentoStack= new Stack<GraphicEditMomento>();
        }

        public void SaveOptions(GraphicEdit ge)
        {
            editMomentoStack.Push(ge.save());
        }
        public void undo(GraphicEdit ge)
        {
            if (editMomentoStack != null && editMomentoStack.Count > 0) { 
            editMomentoStack.Pop();

            ge.restore(editMomentoStack.Peek());
            }
        }
    }
}
