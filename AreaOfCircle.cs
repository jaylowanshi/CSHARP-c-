using System;
class AreaOfCircle{
public static void Main(string[] args){
double pi=3.14;
Console.Write("enter the radius ");
double r=double.Parse(Console.ReadLine());

Console.WriteLine($"Area of circle is {pi*r*r}");

}
}