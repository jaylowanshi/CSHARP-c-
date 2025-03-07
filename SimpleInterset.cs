using System;
class SimpleInteret(){
public static void Main(){
    Console.Write("Enter the Principle ");
    int p=int.Parse(Console.ReadLine());
    Console.Write("Enter the time ");
    int t=int.Parse(Console.ReadLine());
    Console.Write("Enter the rate ");
    int r=int.Parse(Console.ReadLine());

 Console.WriteLine($"simple interest is {(p*t*r/100)} ");


}
}
