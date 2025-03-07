using System;
class PrimeNum{
public static void Main(){
Console.Write("enter the number :- ");
uint num=uint.Parse(Console.ReadLine());
bool flag=true;
if(num==0 && num==1){
Console.WriteLine("0 and 1 both are not a prime number.");
}
else{
for(int i=2;i<=num/2;i++){
if(num%i==0){
flag=false;
break;
}
}
if(flag==true){Console.WriteLine("prime number");}
else Console.WriteLine("not prime");
}
}
}