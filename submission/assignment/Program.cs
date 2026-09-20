// See https://aka.ms/new-console-template for more information
// Program.cs is the place where we write our code.

// .csproj tells us which framework we are using and what packages we have.

// obj/ is used during the build process and contains intermediate files.

// bin/ contains the compiled 
// namespace CsharpBasicAssignment;


// // Makes the code cleaner and reduces indentation since we are not using {}.

// My project uses the classic .sln format.
// One advantage of .slnx is that it is simpler and easier to read.








using System.Security.Cryptography;
using CSharpBasicsAssignment;

PrintHeader("PART A: Project & Structure");
RunProjectStructureDemo();

PrintHeader("PART B: Types, Conversion, and Parsing");
RunTypesDemo();

PrintHeader("PART C: Value Types vs Reference Types");
RunValueVsReferenceDemo();

PrintHeader("PART D1: Scope");
ScopeDemo scopeDemo = new ScopeDemo();
scopeDemo.method1();
scopeDemo.method2();
scopeDemo.method3();
scopeDemo.BlockScope();

PrintHeader("PART D2: Compound Assignment Operators");
scopeDemo.CompoundOperators();

PrintHeader("PART D3: Bitwise Operators");
scopeDemo.BitwiseOperators();

void PrintHeader(string title)
{
    Console.WriteLine();
    Console.WriteLine($"=== {title} ===");
}

void RunProjectStructureDemo()
{
    Console.WriteLine("CSharpBasicsAssignment/");
    Console.WriteLine("  CSharpBasicsAssignment.csproj");
    Console.WriteLine("  Program.cs");
    Console.WriteLine("  Order.cs");
    Console.WriteLine("  STACK_HEAP.md");
    Console.WriteLine("  README.md");
    Console.WriteLine("  ANSWERS.md");
}

void RunTypesDemo()


{

    int x = 5;
    Console.WriteLine($"{x} -  {x.GetType()}");

    long y = 555;


    Console.WriteLine($"{y} -  {y.GetType()}");

    double t = 11.5;

    Console.WriteLine($"{t} -  {t.GetType()}");

    float n = 2.5f;

    Console.WriteLine($"{n} -  {n.GetType()}");

    decimal g = 35.3m;

    Console.WriteLine($"{g} -  {g.GetType()}");


    bool h = true;

    Console.WriteLine($"{h} -  {h.GetType()}");

    char a = 'a';


    Console.WriteLine($"{h} -  {h.GetType()}");

    var q = 10;

    Console.WriteLine($"{q} -  {q.GetType()}");


    y = x;   // this will put a value of int to long since int is  4 byte and long is 8 byte so no casting was  required 

    x = a;  // a  char can be converted to int because each character has a numeric value that int can hold.

    Console.WriteLine(5 / 2);

    Console.WriteLine(5.0 / 2);
    // int division removes the fractional part   while double division keeps it.


    object k = 10;
    Console.WriteLine(k);

    int u = (int)k;

    Console.WriteLine(u);


    string p = "42";

    int e = int.Parse(p);

    Console.WriteLine(p);


    string w = "abc";

    bool isSucced = int.TryParse(w, out int result);

    if (!isSucced)
    {
        Console.WriteLine(" parsing not suucced ");
    }
    else
    {
        Console.WriteLine(" parsing is done ");
    }

   //  g = n; // it will refuse the casting since decimal is base 10 and n is base two so the reprsentation of numbers cant be done  


    g = (decimal)n;






}





void RunValueVsReferenceDemo()
{
    point p1 = new point();
    {
        p1.x = 1;
        p1.y = 2;
    }
    point p2 = p1;
    {
        p2.x = 99;

    }
    Console.WriteLine(p1.x);

    Console.WriteLine(p2.x);
    // they are different in result since struct is a value type not reference so p2 take a coppy of of object p1 and its values not related to p2 
    // Experiment 1 — struct copy semantics 



    Order r1 = new Order();
    {
        r1.OrderId = 1;
        r1.CustomerName = "Mohamed ";
        r1.Quantity = 50;
        r1.UnitPrice = 20;
        r1.TotalPrice = 15;
        r1.IsPaid = true;
        r1.DiscountPercent = 20;
        r1.ShippingCity = "Cairo ";

        r1.Priority = 'P';

        r1.ItemCode = 5;
        r1.caluclatetotal();
        Order r2 = r1;

        r2.IsPaid = true;

        Console.WriteLine(r1.IsPaid); // true 
        Console.WriteLine(r2.IsPaid); // true 
                                      // o1 and o2 reference the same object in the heap.
                                      // Changing the object through o2 is also visible through o1
                                      // because both references point to the same object.



        object boxedOrder = r1;

        Order r3 = (Order)boxedOrder;

        Console.WriteLine(object.ReferenceEquals(r1, r3));

        r2.PrintSummary();
        // Value types like Point store their actual data directly, typically in their containing storage such as the stack for local variables.
        // Assigning a value type like p2 = p1 copies the values, so p1 and p2 are independent.
        // Reference types like Order have their object data on the heap, while variables like r1 and r2 hold references to that object.
        // Assigning r2 = r1 copies the reference, not the Order object, so both variables point to the same object.
        // Storing r1 in an object variable does not create a new Order because Order is already a reference type; only the reference is copied.

    }
}

struct point
{
    public int x;
    public int y;
}

class ScopeDemo
{
    private int x = 10;

    public void method1()
    {
        Console.WriteLine(x);
    }

    public void method2()
    {
        Console.WriteLine(x);

    }
    public void method3()
    {
        int t = 10;
        Console.WriteLine(t);
    }

    public void BlockScope()
    {
        int total = 100;

        for (int i = 0; i < total; i++)
        {
            int s = total;
            
        }

        // Console.WriteLine(s);
        // Error: s is destroyed/out of scope after the block ends.
    }

    public void CompoundOperators()
    {
        int total = 100;

        total += 20;
        Console.WriteLine(total);

        total -= 10;
        Console.WriteLine(total);

        total *= 2;
        Console.WriteLine(total);

        total /= 2;
        Console.WriteLine(total);

        total %= 30;
        Console.WriteLine(total);

        // total += 20 is equivalent to:
        // total = total + 20;
    }
    public void BitwiseOperators()
    {
        int a = 12; // 1100
        int b = 10; // 1010

        Console.WriteLine(a & b); // 1100 & 1010 = 1000 = 8
        Console.WriteLine(a | b); // 1100 | 1010 = 1110 = 14
        Console.WriteLine(a ^ b); // 1100 ^ 1010 = 0110 = 6

        // & is bitwise and evaluates both operands,
        // while && is logical and stops evaluating if the left operand is false.
    }

}




