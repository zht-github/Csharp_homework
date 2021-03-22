using System;

namespace homework2_shape
{
    interface ISelfCheckable
    {
        bool SelfCheck();
    }
   public abstract class Shape
    {
        public double Area { get; set; }//因为要实现自我检测要允许用户随意更改对象参数造成形状错误，所以这里设置成可读可写，否则只读属性更合理
        abstract protected void CalculateArea();
    }
    public class Triangle : Shape,ISelfCheckable
    {
        public Triangle() : this(1, 1) { }
        public Triangle(int height,int width)
        {
            this.Height = height;
            this.Width = width;
            CalculateArea();
        }
        public int Height { get; set; }//与area同理
        public int Width { get; set; }


        public bool SelfCheck()
        {
            if (Area == Height * Width / 2)
            {
                return true;
            }
            else return false;
        }

        protected override void CalculateArea()
        {
            Area = Height * Width / 2;
        }
        public override string ToString()
        {
            return base.ToString() + $":\nheight={Height},length={Width},area={Area};\ncheck result={SelfCheck()}" ;
        }
    }
    public class Rectangular : Shape,ISelfCheckable
    {
        public Rectangular() : this(1, 1){}
        public Rectangular(int length, int width)
        {
            this.Length = length;
            this.Width = width;
            CalculateArea();
        }
        public int Length { get; set; }
        public int Width { get; set; }

        public bool SelfCheck()
        {
            if (Area == Length * Width) return true;
            else return false;
        }

        protected override void CalculateArea()
        {
            Area = Length * Width;
        }
        public override string ToString()
        {
            return base.ToString() + $":\nlength={Length},length={Width},area={Area};\ncheck result={SelfCheck()}";
        }
    }
    public class Square : Shape,ISelfCheckable
    {
        public Square() : this(1) { }
        public Square(int size)
        {
            this.Size = size;
            CalculateArea();
        }
        public int Size { get; set; }

        public bool SelfCheck()
        {
            if (Area == Size * Size) return true;
            else return false;
        }

        protected override void CalculateArea()
        {
            Area = Size * Size;
        }
        public override string ToString()
        {
            return base.ToString() + $":\nsize={Size},area={Area};\ncheck result={SelfCheck()}";
        }
    }
    class Program
    {
        static void Main()
        {
            Triangle t1=new Triangle(1,2);
            Rectangular r1 = new Rectangular(1, 2);
            Square s1 = new Square(1);
            s1.Area = 3;
            Console.WriteLine(t1.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(r1.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(s1.ToString());
        }
    }
}
