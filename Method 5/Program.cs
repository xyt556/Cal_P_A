using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 方法五：使用委托
 */
namespace Method_3
{
    //定义委托：
    public delegate double VolumeDelegate();
    public delegate double SurfaceAreaDelegate();
    //这里定义了两个委托类型，一个用于计算体积，一个用于计算表面积。

    public class Shape
    {
        //Shape 类包含两个委托属性，并在构造函数中初始化它们。
        public VolumeDelegate Volume { get; set; }
        public SurfaceAreaDelegate SurfaceArea { get; set; }

        public Shape(VolumeDelegate volume, SurfaceAreaDelegate surfaceArea)
        {
            Volume = volume;
            SurfaceArea = surfaceArea;
        }
    }

    public class Sphere
    {
        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public double SurfaceArea()
        {
            return 2 * Math.PI * radius * (height + radius);
        }
    }

    public class Cone
    {
        private double radius;
        private double height;

        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }

        public double Volume()
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        public double SurfaceArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.PI * radius * slantHeight + Math.PI * Math.Pow(radius, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用委托：");
            //在 Main 方法中，实例化具体形状类，并将其 Volume 和 SurfaceArea 方法传递给 Shape 类的实例。
            //通过 Shape 类的委托属性调用这些方法并输出结果。
            Sphere sphere = new Sphere(5);
            Shape shapeSphere = new Shape(sphere.Volume, sphere.SurfaceArea);
            Console.WriteLine("Sphere volume: " + shapeSphere.Volume());
            Console.WriteLine("Sphere surface area: " + shapeSphere.SurfaceArea());

            Cylinder cylinder = new Cylinder(2, 10);
            Shape shapeCylinder = new Shape(cylinder.Volume, cylinder.SurfaceArea);
            Console.WriteLine("Cylinder volume: " + shapeCylinder.Volume());
            Console.WriteLine("Cylinder surface area: " + shapeCylinder.SurfaceArea());

            Cone cone = new Cone(3, 8);
            Shape shapeCone = new Shape(cone.Volume, cone.SurfaceArea);
            Console.WriteLine("Cone volume: " + shapeCone.Volume());
            Console.WriteLine("Cone surface area: " + shapeCone.SurfaceArea());

            Console.ReadKey();
        }
    }
}
