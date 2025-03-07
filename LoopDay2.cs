using System;
class LoopDay2{
public void fibo(int n){
     for(int i=1;i<=n;i++){
         for(int j=1;j<=n;j++){
    if((i==1 && i==n) || (i==j && j==n)){Console.Write("*");
}
else Console.Write(" ");
}  
Console.WriteLine(); 
}
  
}
public static void Main(){
   LoopDay2 c1=new LoopDay2();
   c1.fibo(5);
}
}