using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.MementoPattern.GraphicEditorApp
{
    internal class GraphicEditMomento
    {
        private readonly string ShapeType;
        private readonly int x;
        private readonly int y;
        private readonly string color;
        private readonly int size;

        public GraphicEditMomento(string ShapeType , int x, int y , string color , int size)
        {
            this.size = size;
            this.ShapeType = ShapeType;
            this.x = x;
            this.y = y; 
            this.color = color;
        }
        public GraphicEditMomento readState()
        {
            return new GraphicEditMomento(ShapeType,x,y,color,size);
        }

        public string getShapeType()
        {
            return ShapeType;
        }
        public int getY()
        {
            return y;
        }
        public int getX()
        {
            return x;
        }
        public string getColor()
        {
            return color;
        }
        public int getSize()
        {
            return size;
        }
    }
}
