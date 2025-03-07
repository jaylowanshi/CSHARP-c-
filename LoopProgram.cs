using System;
class LoopProgram{
public void Reverse(int num){
int rem,rev=0,temp=num;
   while(num!=0){
   rem=num%10;
   rev=rev*10+rem;
   num/=10;
}
if(temp == rev)
Console.WriteLine($"Palindrome {rev}");
else
Console.WriteLine($"not an Palindrome {rev}");
}
public static void Main(){
LoopProgram obj =new LoopProgram();
Console.WriteLine("Enter the num : ");
int num=int.Parse(Console.ReadLine());
obj.Reverse(num);
}
}