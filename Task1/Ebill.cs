using System;
public class Electricitybill{
public static void Main(){
Console.WriteLine("Enter total units consumed:");
int unit = Convert.ToInt32(Console.ReadLine());
int amount;
if(unit<=200)
{
  amount= unit*2;
}
else if (unit<=350)
{
  amount= 400+((unit-200)*3);
}
else if(unit<=500)
{
  amount=850+((unit-350)*5);
}
else 
{
  amount=1600+((unit-500)*7);
}
Console.WriteLine("Total Electricity Bill:{0}",amount);
}
}