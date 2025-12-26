using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Numerics;
namespace SmallAssignments{
class Program
{
    public static void Main(string[] args)
    {
        double radius=2.5;
        double answer=CircleArea.Area(radius);

        Console.WriteLine(answer);

        int feet=(int)6.2;
        double res=FtCm.Converter(feet);

        Console.WriteLine(res);

        int height=153;
        string checkHeight=Category.HtCat(height);
        Console.WriteLine(checkHeight);

        Console.WriteLine("enter values: a,b,c");
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int c=int.Parse(Console.ReadLine());
        Largest lar =new Largest();
        int largest=lar.Compare(a,b,c);
        Console.WriteLine("The largest value in "+a+" "+b+" "+c+" is : "+largest);
    }
}
}