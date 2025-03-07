using System;
class CompanyDetails{
public void Details(string name,string loc ,string ceo,long count){
Console.WriteLine($" Company name: {name}");
Console.WriteLine($"Company Location: {loc}");
Console.WriteLine($" Company CEO: {ceo}");
Console.WriteLine($" Company Employee Count: {count}");
}

public static void Main(){
Console.Write("enter the Company Name ");
string name=Console.ReadLine();

Console.Write("enter the Company Location ");
string loc=Console.ReadLine();

Console.Write("enter the Company CEO");
string ceo=Console.ReadLine();

Console.Write("enter the Company Employee Count ");
long count=long.Parse(Console.ReadLine());

CompanyDetails cd=new CompanyDetails();
cd.Details(name,loc,ceo,count);
}
}