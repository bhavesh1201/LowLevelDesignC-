using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.TextEditorApp
{

    //Momento Class : Stores the internal state of the text editor
    internal class TextEditorMomento
    {

        public const double randomPiValue = 3.14; // This is const and this will be changed here only
        public readonly string content; // readonly can be changed in constructor only
        public string somevalue; // can be changed anywhere

        public TextEditorMomento(string text)
        {
            content = text; // READONLY CHANGED HERE INSIDE CONSTRUCTOR
        }

        public string read()
        {
            return content;
        }
        public void someoperation()
        {
            //randomPiValue = 4.4; //ERROR AGYA WHILE CHANGING
            //content = ""; // ERROR AGYA READONLY MAIN BI
            //somevalue = ""; // NO ERROR IN PUBLIC WALA MAIN
        }
    }
}
