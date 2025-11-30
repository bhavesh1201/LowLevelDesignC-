
using LowLevelDesignC_.BehaviouralPattern.MementoPattern.GraphicEditorApp;
using LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode;
using System;

namespace MyApp
{
    internal class Program
    {

        //Call below method to test undo functionality (implemented using momento pattern) in Graphic Editor App
        public static void  GraphicEditorCase()
        {
            
            CareTaker ct = new CareTaker(); 
            GraphicEdit ge = new GraphicEdit();

            for(int i=0; i < 3; i++)
            {
                Console.WriteLine("Enter Your Shape Type");
                string shape=Console.ReadLine();
                Console.WriteLine("Enter Your Shape X cordinate");

                int x = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter Your Shape Y cordinate");

                int y = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter Your Shape Color");

                string color = Console.ReadLine();
                Console.WriteLine("Enter Your Shape Size");

                int size = Convert.ToInt32( Console.ReadLine());

                ge.Save( shape,  x,  y,  color,  size);
                ct.SaveOptions(ge);

            }
            ct.undo(ge);
            ct.undo(ge);
            ge.read();  
        }
        static void Main(string[] args)
        {

            WeatherForcastCase();
           // GraphicEditorCase();    
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

            //CareTaker ct = new CareTaker(); ;
            //TextEditor2 nt = new TextEditor2();

            //nt.write("Hi");
            //ct.save(nt);

            ////nt.save();
            //nt.write("hey");
            //ct.save(nt);
            //nt.write("hey2");
            //ct.save(nt);
            //ct.undo(nt);
            //ct.undo(nt);
            //nt.read();


        }

        public static void WeatherForcastCase()
        {
            WeatherForcase wfc = new WeatherForcase();
            IphoneDevice iphoneDevice = new IphoneDevice();

            
            AndriodDevive andriodDevive= new AndriodDevive();
            WindowsDevice windowsDevice = new WindowsDevice();
            wfc.addObserver(andriodDevive);
            wfc.addObserver(iphoneDevice);
            //wfc.addObserver(iphoneDevice);

            wfc.addObserver(windowsDevice);


            wfc.setTemprature(32.4f);
            wfc.setTemprature(3.4f);
            wfc.removeObserver(iphoneDevice);
            wfc.setTemprature(5.4f);
        }
    }
}