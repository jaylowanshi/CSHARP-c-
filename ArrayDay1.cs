using System;
class ArrayDay1{
public static void Main(){
     int[] arr=new int[5];
int sum=0;
      Console.WriteLine("enter the array elemnts");
     for(int i=0;i<5;i++) 
      {
        arr[i]=int.Parse(Console.ReadLine());
       if(arr[i]%2!=0)
        sum +=arr[i];
      }
      Console.WriteLine($"sum of the element is {sum}");
    
}}