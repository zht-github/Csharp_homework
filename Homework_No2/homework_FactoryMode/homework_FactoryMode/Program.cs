using homework2_shape;
using System;

namespace homework_FactoryMode
{
    class ShapeFactory
    {
        public static Shape CtreateShape(string type)
        {
            switch (type)
            {
                case "Rectangular": return new Rectangular();
                case "Triangle": return new Triangle();
                case "Square": return new Square();
                default: throw new Exception("CANNOT RECONGINZE THIS SHAPE!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = ShapeFactory.CtreateShape("Triangle") as Triangle;
            Rectangular r1 = ShapeFactory.CtreateShape("Rectangular") as Rectangular;
            Square s1 = ShapeFactory.CtreateShape("Square") as Square;

            s1.Size = 3;//更新边长而不更新面积，制造错误，使SelfCheck()返回值为false;

            Console.WriteLine(t1.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(r1.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(s1.ToString());
        }
    }
}
