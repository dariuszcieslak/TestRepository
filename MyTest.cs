using System;
using System.Dynamic;
public class MyTest
{
    public delegate int myDelegate(int x) ;
    public void Test() {

        dynamic x = new ExpandoObject();
        x.a = "adfa";
        x.b = 1;

        Console.WriteLine("dsfas" + x.a + " and " + x.b);
    }

    public int Function(int a) => (int)Math.Pow(a,2);
}
