using System;
using System.Collections.Generic;

using static System.Console;

namespace Delegate // 대리자 , 타입
{
    class Calculator
    {
        public delegate void calculator(int a, int b);
        public void Process(calculator calculator)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


//class Program
//{
//    public delegate void SendStrigng(string message);

//    static void Main(string[] args)
//    {
//        SendStrigng sayHello, sayGoodbye, multiDelegate;
//        sayHello = Hello;
//        sayGoodbye = GoodBye;

//        multiDelegate = sayHello + sayGoodbye;
//        multiDelegate("윤인성");
//        WriteLine();

//        multiDelegate -= sayGoodbye;
//        multiDelegate("윤인성");
//    }

//    public static void Hello(string message)
//    {
//        WriteLine("안녕하세요. " + message + "씨....!");
//    }
//    public static void GoodBye(string message)
//    {
//        WriteLine("안녕히가세요.  " + message + "씨....!");
//    }
//}




//class Student
//{
//    public string Name { get; set; }
//    public double Score { get; set; }

//    public Student(string name, double score) { this.Name = name; this.Score = score; }
//    public override string ToString() { return this.Name + " : " + this.Score; }
//}

//class Students
//{
//    private List<Student> listOfStudent = new List<Student>(); // 목록
//    public delegate void PrintProcess(Student list);                     // 델리게이트 선언
//    public void Add(Student student) { listOfStudent.Add(student); }
//    public void Print()
//    {
//        foreach (var item in listOfStudent) { WriteLine(item.ToString()); }
//    }
//    public void Print(PrintProcess process)
//    {                               // 델리게이트 사용
//        foreach (var item in listOfStudent) process(item);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Students students = new Students();
//        students.Add(new Student("윤인성", 4.2));
//        students.Add(new Student("연하진", 4.4));

//        students.Print();

//        students.Print((student) =>
//        {
//            WriteLine();
//            WriteLine("이름" + " : " + student.Name);
//            WriteLine("학점" + " : " + student.Score);
//        }
//        );
//    }
//}





//public delegate void TestDelegateA();
//class Program
//{
//    public delegate void TestDelegateB();
//    public delegate void TestDelegate();

//    static void main(string[] args)
//    {
//        TestDelegate delegateA = TestMethod;

//        TestDelegate delegateB = delegate () { };

//        TestDelegate delegateC = () => { };

//        delegateA();
//        delegateB();
//        delegateC();

//    }

//    static void TestMethod()
//    {

//    }
//}





//    int Add(int a, int b)
//    {
//        return a + b;
//    }
//    //(a, b) => a + b;

//    class Product
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }
//    }
//    static void Main(string[] args)
//    {
//        List<Product> products = new List<Product>()
//            {
//                new Product() { Name = "감자", Price = 500 },
//                new Product() { Name = "사과", Price = 100 },
//                new Product() { Name = "배추", Price = 300 },
//                new Product() { Name = "상추", Price = 100 }
//            };
//        //products.RemoveAll(RemovePrice);
//        products.RemoveAll(obj => obj.Price > 300);

//        //products.Sort(SortWithPriceAndName); // 1. 델리게이트 사용
//        //products.Sort(                                            // 2. 무명 델리게이트
//        //                delegate (Product a, Product b)
//        //                {
//        //                   return a.Price.CompareTo(b.Price);
//        //                }
//        //    );
//        //products.Sort(
//        //                (Product a, Product b) =>                      // 3. 람다
//        //                {
//        //                    return a.Price.CompareTo(b.Price);
//        //                }
//        //    );     
//        //products.Sort((a, b) => { return a.Price.CompareTo(b.Price); }); // 3. 람다

//        foreach (var item in products)
//        {
//            WriteLine(item.Name + " : " + item.Price);
//        }
//    }

//    // int Comparison<in T>(T x, T y)

//    static bool RemovePrice(Product obj)
//    {
//        if (obj.Price > 300)
//            return true;
//        else
//            return false;
//    }

//    static int SortWithPrice(Product a, Product b)
//    {
//        return a.Price.CompareTo(b.Price);
//    }

//    static int SortWithName(Product a, Product b)
//    {
//        return b.Name.CompareTo(a.Name);
//    }

//    static int SortWithPriceAndName(Product a, Product b)
//    {
//        int rt = a.Price.CompareTo(b.Price);
//        if (rt == 0) return a.Name.CompareTo(b.Name);
//        else return rt;
//    }

//}





//static int StringLength(string a)
//{
//    return a.Length;
//}

//delegate int DelStringLen(string a);

//static void Main(string[] args)
//{
//    DelStringLen delString = StringLength;
//    Func(StringLength);
//}

//static void Func(DelStringLen del)
//{
//    WriteLine(del("Hello"));
//}








//static int Add(int a, int b) // int (int, int)
//{
//    return a + b;
//}
//static int Sub(int a, int b) // int (int, int)
//{
//    return a - b;
//}



//delegate int MyDel(int a, int b); // 델리게이트 정의


//static void Main(string[] args)
//{
//    //Type Name = Value;
//    //int       a        =    0;     Func(a);

//    MyDel myDel = Sub; // 델리케이트 선언 = 초기화


//    int rt = myDel(1, 2);

//}

//static void Func(int a)
//{

//}
