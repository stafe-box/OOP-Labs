// See https://aka.ms/new-console-template for more information

namespace lab1
{
    public abstract class Shape
    {
        protected int _size;

        public int Size { get { return _size; } set { _size = value; } }

        public virtual int Area()
        {
            return 0;
        }

        public virtual int Volume()
        {
            return 0;
        }

        public virtual int Perimetr()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        public override int Area()
        {
            return _size * _size;
        }

        public override int Volume()
        {
            return 0;
        }

        public override int Perimetr()
        {
            return _size*4;
        }
    }

    public class Cube : Shape
    {
        public override int Area()
        {
            return _size * _size * 6;
        }

        public override int Volume()
        {
            return _size * _size * _size;
        }

        public override int Perimetr()
        {
            return _size * 12;
        }
    }

    public class Program
    {
        public static int Main()
        {
            Console.Write("enter demention: ");
            Shape Oleg = new Square();
            Shape Grigoriy = new Cube();
            Oleg.Size = (Convert.ToInt32(Console.ReadLine()));
            Grigoriy.Size = Oleg.Size;
            Console.WriteLine($"\nSquare: S = {Oleg.Area()}; P = {Oleg.Perimetr()}\n");
            Console.WriteLine($"Cube: S = {Grigoriy.Area()}; P = {Grigoriy.Perimetr()}; V = {Grigoriy.Volume()}\n");
            Console.ReadKey();
            return 0;
        }
    }
}

