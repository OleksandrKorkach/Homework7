using System.Text;

namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFigure figure = new Triangle(10, 20, 30);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }

    class Triangle : IFigure
    {
        private int firstSide;
        private int secondSide;
        private int thirdSide;

        public Triangle(int fSide, int sSide, int tSide)
        {
            firstSide = fSide;
            secondSide = sSide;
            thirdSide = tSide;
        }

        public IFigure Clone()
        {
            return new Triangle(firstSide, secondSide, thirdSide);
        }
        
        public void GetInfo()
        {
            Console.WriteLine("Triangle with sides {0}, {1}, {2}", firstSide, secondSide, thirdSide);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }
}