using LowLevelDesignC_.BehaviouralPattern.MementoPattern;
using System;

namespace MyApp
{
    internal class Program
    {


        public static void  GraphicEditorCase()
        {

        }
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");

            //TextEditor newText= new TextEditor();
            //newText.write("Hi");
            //newText.write("Bonjur");
            //newText.write("Namste");

            //newText.read();
            //newText.undo();
            //newText.undo();
            //newText.read();
            //newText.redo();
            //newText.read();
            //Using momento Pattern

            CareTaker ct = new CareTaker(); ;
            TextEditor2 nt = new TextEditor2();

            nt.write("Hi");
            ct.save(nt);

            //nt.save();
            nt.write("hey");
            ct.save(nt);
            nt.write("hey2");
            ct.save(nt);
            ct.undo(nt);
            ct.undo(nt);
            nt.read();


        }
    }
}