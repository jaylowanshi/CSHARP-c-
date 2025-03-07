using System;
class JaggedDemo{
static void Main(){
       int[][] arr=new int[4][];
       arr[0]=new int[4];
       arr[1]=new int[5];
       arr[2]=new int[6];
       arr[3]=new int[8];


//Accessing values of jagged array by using nested foreach loop
foreach(int[] iarr in arr)
 {
    foreach(int x in iarr)
        Console.Write(x +" ");
        Console.WriteLine();

}
 Console.WriteLine("--------------------------------------"); 
//Assigning values of jagged array by using nested foreach in for loop
foreach(int[] iarr in arr)
 {
    for(int i=0;i<iarr.Length;i++)
        {
            iarr[i]=i+1;
}
}

//Assigning values of jagged array by using nested for loop in foreach loop

foreach(int[] iarr in arr)
 {
    for(int i=0;i<iarr.Length;i++)
        Console.Write(iarr[i] +" ");
        Console.WriteLine();

}
 Console.WriteLine("--------------------------------------"); 

for(int i=0;i<arr.GetLength(0);i++){
for(int j=0;j<arr[i].Length;j++)
      Console.Write(arr[i][j]+" ");
Console.WriteLine();
}

}
}