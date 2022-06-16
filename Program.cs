using System;

namespace Havit
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape[6];

            shape[0] = new Rectangle(12, 22);
            shape[1] = new Triangle(4, 8);
            shape[2] = new Circle(8);
            shape[3] = new Triangle(16, 20);
            shape[4] = new Rectangle(5, 9);
            shape[5] = new Circle(4);

            var area = new double[6];

            foreach(var sh in shape) {
                Console.WriteLine("{0}", sh);
            }

            Console.WriteLine();

            for(int i = 0; i < shape.Length; i++) {
                area[i] = shape[i].CalculateSurface();
            }

            for(int j = 0; j < area.Length; j++) {
                Console.WriteLine($"Area: {area[j]}");
            }

            



            Console.ReadLine();
        }

        public abstract class Shape {
            public double Width{ get; set; }
            public double Height{ get; set; }

            public Shape(double width) {
                Width = Height = Width;
            }

            public Shape(double width, double height) {
                this.Width = width;
                this.Height = height;
            }

            public abstract double CalculateSurface();
        }

        public class Rectangle : Shape {
            public Rectangle(double width, double height) : base(width, height) {

            }

            public override double CalculateSurface() {
                 return Width * Height;
            }
        }

        public class Triangle : Shape {
            public Triangle(double width, double height) : base(width, height) {
                
            }

            public override double CalculateSurface() {
                return Width * Height / 2;
            }
        }

        public class Circle : Shape {
            public double Radius{ get; set; }

            public Circle(double radius) : base(radius) {
                this.Radius = radius;
            }

            public override double CalculateSurface() {
                return Math.Round(Math.PI * Radius * Radius);
            }
        }
    }
}
