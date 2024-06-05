using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 方法二：C#中的虚方法（virtual method）是一种允许子类重写的方法。
 * 如果一个类中的方法被声明为虚方法，那么它的子类可以通过override关键字来重写这个方法，从而改变它的实现方式。
 * 在C#中，使用virtual关键字来声明一个虚方法。
 */


namespace Method_2
{
    public class Shape
    {
        public virtual double Volume()
        {
            return 0;
        }
        public virtual double SurfaceArea()
        {
            return 0;
        }
    }
    // 球体
    public class Sphere : Shape
    {
        private double radius; // 球体半径
        public Sphere(double r)
        {
            radius = r;
        }
        public override double Volume() // 重写父类的体积计算方法
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
        public override double SurfaceArea() // 重写父类的表面积计算方法
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
    // 圆柱体
    public class Cylinder : Shape
    {
        private double radius; // 圆柱底面半径
        private double height; // 圆柱高
        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }
        public override double Volume() // 重写父类的体积计算方法
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public override double SurfaceArea() // 重写父类的表面积计算方法
        {
            return 2 * Math.PI * radius * (height + radius);
        }
    }
    // 圆锥体
    public class Cone : Shape
    {
        private double radius; // 圆锥底面半径
        private double height; // 圆锥高
        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }
        public override double Volume() // 重写父类的体积计算方法
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }
        public override double SurfaceArea() // 重写父类的表面积计算方法
        {
            double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.PI * radius * slantHeight + Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用虚方法：");
            Sphere sphere = new Sphere(5);
            Console.WriteLine("Sphere volume: " + sphere.Volume()); // 输出球体的体积
            Console.WriteLine("Sphere surface area: " + sphere.SurfaceArea()); // 输出球体的表面积
            Cylinder cylinder = new Cylinder(2, 10);
            Console.WriteLine("Cylinder volume: " + cylinder.Volume()); // 输出圆柱体的体积
            Console.WriteLine("Cylinder surface area: " + cylinder.SurfaceArea()); // 输出圆柱体的表面积
            Cone cone = new Cone(3, 8);
            Console.WriteLine("Cone volume: " + cone.Volume()); // 输出圆锥体的体积
            Console.WriteLine("Cone surface area: " + cone.SurfaceArea()); // 输出圆锥体的表面积
            Console.ReadKey();
        }
    }
}
