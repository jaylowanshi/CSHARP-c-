using System;
class AddNumber{
 public static void Main(string[] args){
     int sum=0;
foreach(string i in args)
sum +=int.Parse(i);
Console.WriteLine($"sum of index {args.Length} is {sum}") ;
}
}