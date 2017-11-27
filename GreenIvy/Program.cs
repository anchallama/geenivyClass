using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using g= GreenIvy.Maths.Arithmetic;
using dsa=GreenIvy.DSA;
namespace GreenIvy
{
    class Program
    {
        static void Main(string[] args)
        {
            //float[] arr = new float[] {1,2,3,4,5,6,7,8,9,10 };

            //g.General obj1 = new g.General();
            //Console.WriteLine($"the sum of 5 and 6 are {obj1.Add(5, 6)}");
            //Console.WriteLine($"the sum of 5, 6 and 7 are {obj1.Add(5, 6,7)}");
            //Console.WriteLine($"the sum of 1,2,3,4,5,6,7,8,9 and 10 are {obj1.Add(arr)}");

            //dsa.Stack objStack = new DSA.Stack();

            ////user defined stacks
            //dsa.UserDefinedStack objStack = new DSA.UserDefinedStack(7);
            //Console.WriteLine("values before adding anything");
            //Console.WriteLine(objStack.GetValues());

            //objStack.Push(1);
            //objStack.Push(2);
            //objStack.Push(5);
            //objStack.Push(3);
            //objStack.Push(4);

            ////objStack.store = new int[] { 23, 234, 45, 456, 45 };

            //Console.WriteLine("values after adding 1,2,5,3,4");
            //Console.WriteLine(objStack.GetValues());


            //objStack.Pop();
            //objStack.Pop();

            //Console.WriteLine("values after pop");
            //Console.WriteLine(objStack.GetValues());


            ////Templates
            //dsa.UserDefinedStackTemplate<string> objStack = new DSA.UserDefinedStackTemplate<string>(12);

            //Console.WriteLine("values before adding anything");
            //Console.WriteLine(objStack.GetValues());

            //objStack.Push("a");
            //objStack.Push("b");
            //objStack.Push("c");
            //objStack.Push("d");
            //objStack.Push("e");

            ////objStack.store = new int[] { 23, 234, 45, 456, 45 };

            //Console.WriteLine("values after adding a,b,c,d,e");
            //Console.WriteLine(objStack.GetValues());


            //objStack.Pop();
            //objStack.Pop();

            //Console.WriteLine("values after pop");
            //Console.WriteLine(objStack.GetValues());

            //dsa.UserDefinedStackTemplate<float> objStack1 = new DSA.UserDefinedStackTemplate<float>(12);

            //Console.WriteLine("values before adding anything");
            //Console.WriteLine(objStack1.GetValues());

            //objStack1.Push(1.2f);
            //objStack1.Push(3.2f);
            //objStack1.Push(1.5f);
            //objStack1.Push(6.5f);
            //objStack1.Push(0.005f);

            ////objStack.store = new int[] { 23, 234, 45, 456, 45 };

            //Console.WriteLine("values after adding");
            //Console.WriteLine(objStack1.GetValues());


            //objStack1.Pop();
            //objStack1.Pop();

            //Console.WriteLine("values after pop");
            //Console.WriteLine(objStack1.GetValues());


            ////interface
            //Shapes.IShape s = new Shapes.Triangle();
            //s.Area();
            //s.Perimeter();


            //s = new Shapes.Rectangle();
            //s.Area();
            //s.Perimeter();

            //ClassTest.Shapes = new List<Shapes.IShape>();

            //ClassTest.Shapes.Add(new Shapes.Triangle());
            //ClassTest.Shapes.Add(new Shapes.Rectangle());
            //ClassTest.Shapes.Add(new Shapes.Circle());

            //foreach (var item in ClassTest.Shapes)
            //{
            //    item.Area();
            //    item.Perimeter();
            //}


            //inheritence
            GrandFather granFather = new GrandFather("GFirstName","GMiddleName","GLastName");
            Father father = new Father("FFirstName","FMiddleName","FLastName","Engineering");
            Son son = new Son();
            Console.WriteLine(granFather.Details());
            Console.WriteLine(father.Details());
            Console.WriteLine(son.Details());



            //MyClass<Shapes.Triangle> objs= new MyClass<Shapes.Triangle>();

            Console.ReadLine();

        }
    }

    public class ClassTest
    {
        public static List<Shapes.IShape> Shapes { get; set; }

        public List<Shapes.IShape> Shapes2 { get; set; }

        public ClassTest()
        {
            Shapes2 = new List<GreenIvy.Shapes.IShape>();

        }
        public ClassTest(List<Shapes.IShape> Shapes2)
        {
            //Shapes2 = Shapes2;
            this.Shapes2 = Shapes2;
        }

    }


    public class GrandFather
    {
        public GrandFather()
        {

        }
        public GrandFather(string FirstName, string MiddleName,string LastName)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public virtual string Details()
        {
            return $"First Name {FirstName}\nMiddle Name {MiddleName}\nLastName {LastName}\n";
        }

    }

    public class Father : GrandFather
    {
        public Father() : base()
        {

        }
        public Father(string FirstName,string MiddleName, string LastName, string Education) : base(FirstName,MiddleName,LastName)
        {
            this.Education = Education;
        }

        public override string Details()
        {
            return $"Education {this.Education}\n";
        }


        public string Education { get;set;}
    }

    public class Son :Father
    {
        public new string Details()
        {
            return "No details";
        }
    }
}
