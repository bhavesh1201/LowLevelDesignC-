using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.GraphicEditorApp
{
    internal class GraphicEdit
    {
        private string ShapeType;
        private int x;
        private int y;
        private string color;
        private int size;

        public void Save(string shape, int x, int y, string color, int size)
        {
            ShapeType = shape;
            this.x = x;
            this.y = y;
            this.color = color;
            this.size= size;
        }

        public void read()
        {
            Console.WriteLine($"Shape : {ShapeType}, Cordinates ({x} , {y}) ,Color :{color} , Size : {size} ");
        }
       
        public GraphicEditMomento save()
        {
            return new GraphicEditMomento(ShapeType,x,y,color,size);
        }
        public void restore(GraphicEditMomento ge)
        {


            ShapeType = ge.getShapeType();
            x = ge.getX();
            y=ge.getY();
            color = ge.getColor();  
            size = ge.getSize();
        }

    }
}
