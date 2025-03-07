using System;
class SwapNum{
public static void Main(string[] args){
Console.Write("enter two number");
int num1=int.Parse(Console.ReadLine());
int num2=int.Parse(Console.ReadLine());

Console.WriteLine($"Before swaping a={num1}, b={num2}");
int temp=num1;
num1=num2;
num2=temp;

Console.WriteLine($"After swaping a={num1}, b={num2}");
}
}