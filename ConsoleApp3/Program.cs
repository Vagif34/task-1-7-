using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
                    
         
        
    }
    abstract class Figure
    {
        public abstract void CalcArea();
    }
    class Square
    {
        private double _side;

        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value >= 0)
                {
                    _side = value;
                }
            }
        }
    }
    class Rectagular:Figure
    {
        public override void CalcArea()
        {
            Console.WriteLine();
        }
        private double _width;
        private double  _length;
        public Rectagular()
        {
            _length = Length;
            _width = Width;
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
            }
        }
    }
   

}
