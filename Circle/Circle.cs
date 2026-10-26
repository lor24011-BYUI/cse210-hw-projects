using System;
class Program
{
     static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }

}