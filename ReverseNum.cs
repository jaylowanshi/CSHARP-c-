using System;
class ReverseNum{
public static void Main(){
Console.WriteLine("enter the number : ");
int num=int.Parse(Console.ReadLine());
int rem,rev=0;
int temp=num;
while(num!=0){
rem=num%10;
rev=rev*10+rem;
num/=10;
}
if(temp==rev){
Console.WriteLine("Palindrome");
}
else
Console.WriteLine("Not palindrome");
}
}