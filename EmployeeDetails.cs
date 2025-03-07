using System;
class EmployeeDetails{

public void Details(string name,int Id,double sal){
Console.WriteLine($"Employee Name :{name}");
Console.WriteLine($"Employee ID :{Id}");
Console.WriteLine($"Employee Salary :{sal}");
}
 static void Main(){
EmployeeDetails emp=new EmployeeDetails();
Console.Write("enter employee name ");
string name=Console.ReadLine();
Console.Write("enter employee Id ");
int Id=int.Parse(Console.ReadLine());
Console.Write("enter employee Salary ");
double sal=double.Parse(Console.ReadLine());
emp.Details(name,Id,sal);
}
}