using System;
public class Patient{
 public static void Main(){
 Console.WriteLine("Enter the patient's age:");
int age = Convert.ToInt32(Console.ReadLine());

if(age<16)
Console.WriteLine("This is a Paediatric case");
else
Console.WriteLine("This ia an adult Case");




}
}