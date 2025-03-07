using System;
class StudentDeatils{
public void Details(string name,int id,string cour,long num){
Console.WriteLine($" student name: {name}");
Console.WriteLine($" student ID: {id}");
Console.WriteLine($" student Course: {cour}");
Console.WriteLine($" student Number: {num}");
}

public static void Main(){
Console.Write("enter the student name");
string name=Console.ReadLine();
Console.Write("enter the student ID");
int Id=int.Parse(Console.ReadLine());
Console.Write("enter the student Course");
string Cour=Console.ReadLine();
Console.Write("enter the student Number");
long num=long.Parse(Console.ReadLine());
StudentDeatils st=new StudentDeatils();
st.Details(name,Id,Cour,num);
}
}