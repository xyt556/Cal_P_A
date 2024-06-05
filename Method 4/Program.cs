using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 方法四：使用接口
 */
namespace Method_4
{
    public interface IShape
    {
        double GetSurfaceArea(); // 计算表面积
        double GetVolume();      // 计算体积
    }
    public class Sphere : IShape
    {
        private double radius;
        public Sphere(double r)
        {
            radius = r;
        }
        public double GetSurfaceArea()
        {
            return 4 * Math.PI * radius * radius;
        }
        public double GetVolume()
        {
            return (4 / 3.0) * Math.PI * radius * radius * radius;
        }
    }
    public class Cylinder : IShape
    {
        private double radius;
        private double height;
        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }
        public double GetSurfaceArea()
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
        }
        public double GetVolume()
        {
            return Math.PI * radius * radius * height;
        }
    }
    public class Cone : IShape
    {
        private double radius;
        private double height;
        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }
        public double GetSurfaceArea()
        {
            double l = Math.Sqrt(radius * radius + height * height);
            return Math.PI * radius * (radius + l);
        }
        public double GetVolume()
        {
            return (1 / 3.0) * Math.PI * radius * radius * height;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("使用接口：");
            // 计算球的表面积和体积
            Sphere sphere = new Sphere(5);
            Console.WriteLine("Sphere Surface Area: " + sphere.GetSurfaceArea());
            Console.WriteLine("Sphere Volume: " + sphere.GetVolume());
            // 计算圆柱的表面积和体积
            Cylinder cylinder = new Cylinder(3, 5);
            Console.WriteLine("Cylinder Surface Area: " + cylinder.GetSurfaceArea());
            Console.WriteLine("Cylinder Volume: " + cylinder.GetVolume());
            // 计算圆锥的表面积和体积
            Cone cone = new Cone(4, 6);
            Console.WriteLine("Cone Surface Area: " + cone.GetSurfaceArea());
            Console.WriteLine("Cone Volume: " + cone.GetVolume());
            Console.ReadKey();
        }
    }
}
