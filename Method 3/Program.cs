using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 方法三：使用抽象类
 */
namespace Method_3
{
    public abstract class Shape
    {
        public abstract double Volume();

        public abstract double SurfaceArea();
    }

    public class Sphere : Shape
    {
        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double SurfaceArea()
        {
            return 2 * Math.PI * radius * (height + radius);
        }
    }

    public class Cone : Shape
    {
        private double radius;
        private double height;

        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }

        public override double Volume()
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double SurfaceArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.PI * radius * slantHeight + Math.PI * Math.Pow(radius, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用抽象类：");
            Sphere sphere = new Sphere(5);
            Console.WriteLine("Sphere volume: " + sphere.Volume());
            Console.WriteLine("Sphere surface area: " + sphere.SurfaceArea());

            Cylinder cylinder = new Cylinder(2, 10);
            Console.WriteLine("Cylinder volume: " + cylinder.Volume());
            Console.WriteLine("Cylinder surface area: " + cylinder.SurfaceArea());

            Cone cone = new Cone(3, 8);
            Console.WriteLine("Cone volume: " + cone.Volume());
            Console.WriteLine("Cone surface area: " + cone.SurfaceArea());
            Console.ReadKey();
        }
    }
}
