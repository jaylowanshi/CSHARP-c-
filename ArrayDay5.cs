using System;
class ArrayDay5{
public static void Main(){
int sum=0;
int[,] arr=int arr[4,4];
for(int i=0;i<4;i++){
for(int j=0;j<4;j++){
int arr[i,j]=int.Parse(Console.ReadLine());
}
}
for(int i=0;i<4;i++){
for(int j=0;j<4;j++){
   if(i==j){
sum+=arr[i,j];
}
}
}
Console.WriteLine("Sum of diagonal is {sum}");
}
}